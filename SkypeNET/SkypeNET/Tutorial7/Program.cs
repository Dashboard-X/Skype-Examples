﻿using System;
using System.Collections.Generic;
using Skypekit.NET;
using com.skype.api;
using System.Threading;

namespace Tutorial7
{
    /**
 * Copyright (C) 2010-2012 Skype
 *
 * All intellectual property rights, including but not limited to copyrights,
 * trademarks and patents, as well as know how and trade secrets contained in,
 * relating to, or arising from the internet telephony software of
 * Skype Limited (including its affiliates, "Skype"), including without
 * limitation this source code, Skype API and related material of such
 * software proprietary to Skype and/or its licensors ("IP Rights") are and
 * shall remain the exclusive property of Skype and/or its licensors.
 * The recipient hereby acknowledges and agrees that any unauthorized use of
 * the IP Rights is a violation of intellectual property laws.
 *
 * Skype reserves all rights and may take legal action against infringers of
 * IP Rights.
 *
 * The recipient agrees not to remove, obscure, make illegible or alter any
 * notices or indications of the IP Rights and/or Skype's rights and
 * ownership thereof.
 */

    /**
 * Getting Started With SkypeKit: Tutorial Application, Step 7.
 *
 * In Step 6, we wrote a SkypeKit dialer that took a Skype Name from a command-line argument and
 * initiated a voice call. In this step, we will initiate a conference with at least two other parties.
 * 
 * This example illustrates a simple SkypeKit-based program that:
 * <ol>
 *   <li>Takes a Skype Name, password, some arbitrary number of call targets, and
 *       optional AppKeyPair PEM file pathname as command-line arguments</li>
 *   <li>Initiates login for that user</li>
 *   <li>Waits until the login process is complete</li>
 *   <li>Creates a new Conversation object.</li>
 *   <li>Creates a String array containing the Skype Names of our call targets</li>
 *   <li>Assign the String array to our conference by invoking <code>Conversation.AddConsumers</code></li>
 *   <li>Obtains a resultant list of Participant references</li>
 *   <li>Loops through the list of Participants (that will include <em>this</em> user) and
 *       rings each one <em>except</em> ourselves</li>
 *   <li>Initiates logout when any of the parties ends the call or the call cannot be connected to
 *       <em>any</em> party</li>
 *   <li>Waits until logout is complete</li>
 *   <li>Cleans up and exits</li>
 * </ol>
 * 
 * @author Andrea Drane (ported/refactored from existing C++ tutorial code)
 * 
 * @since 1.0
 */
    class Program
    {
        /**
	 * Info/Debug console output message prefix/identifier tag.
	 * Corresponds to class name.
	 * 
	 * @since 1.0
	 */
        public static String MY_CLASS_TAG = "Tutorial_7";
        /**
         * Index of the account name in the command line argument list.
         * 
         * @since 1.0
         */
        public static int ACCOUNT_NAME_IDX = 0;

        /**
         * Index of the account password in the command line argument list.
         * 
         * @since 1.0
         */
        public static int ACCOUNT_PWORD_IDX = 1;

        /**
         * Index of the first (required) call target argument in the command line argument list.
         * 
         * @since 1.0
         */
        public static int FIRST_TGT_ARG_IDX = (ACCOUNT_PWORD_IDX + 1);

        /**
         * Number of required arguments in the command line argument list.
         * This includes the minimum of <em>two</em> call targets (Skype Names). 
         * 
         * @since 1.0
         */
        public static int REQ_ARG_CNT = 4;

        /**
         * Key introducing/identifying the pathname of an AppKeyPair file
         * among the optional command line arguments.
         * <p>
         *   <b>Any optional AppKeyPair PEM file pathname <em>must</em> be prefixed with this key string to
         *      distinguish it from any call target.</b>
         * </p>
         * <p>
         *   For example:
         *   <pre>
         *       Tutorial_7 myAccountName myAccountPword callTgt1 callTgt2 ... -appKeyPair:/MyHome/MyCredentials/MyCert.pem
         *   </pre>
         * </p>
         * 
         * @since 1.1
         */
        public static String APP_KEY_PAIR_OPT_KEY = "-appKeyPair:";

        /**
         * Call target names.
         * <br /><br />
         * Let the transformation of the accumulated call targets
         * determine the actual size of the array (which must be at
         * least two). com.skype.api.Conversation.addConsumers (and 
         * similar methods that accept a list of identities) appear to
         * assume that <em>each</em> slot contains a <em>valid</em>
         * identity, since empty slots cause a NullPointerException!
         * 
         * @since 1.0
         */
        private static String[] myCallTargets = new String[2];

        private static AppKeyPairMgr myAppKeyPairMgr = new AppKeyPairMgr();
        private static MySession mySession = new MySession();

        /**
         * Main loop.
         * 
         * @param args
         * <ol>
         *   <li>Name of the target Skype account.</li>
         *   <li>Password for the target Skype account.</li>
         *   <li>Skype Names of people to conference in.</li>
         *   <li>Optional arguments (in any order):
         *     <ul>
         *       <li>Some number additional Skype Names of people to conference in</li>
         *       <li>Pathname of aan AppKeyPair PEM file 
         *           (preceded by {@link #APP_KEY_PAIR_OPT_KEY}).</li>
         *      </ul>
         *    </li>
         * </ol>
         * 
         * @since 1.0
         */
        public static void Main(String[] args)
        {

            bool foundAppKeyPairOptKey = false;

            if (args.Length < REQ_ARG_CNT)
            {
                MySession.myConsole.printf("Usage is %s accountName accountPassword callTarget1 ... callTargetN [%s:appKeyPairPathname]%n%n",
                        MY_CLASS_TAG, APP_KEY_PAIR_OPT_KEY);
                return;
            }
            MySession.myConsole.printf("%s: main - Parsing command line arguments:%n", MY_CLASS_TAG);
            int i = args.Length - FIRST_TGT_ARG_IDX;	// Call target names (and any AppToken file
            int j = FIRST_TGT_ARG_IDX;					// pathname) follow...
            int k = 0;
            String argStr;
            List<String> callTgtList = new List<String>((i - 1));
            while (--i >= 0)
            {
                argStr = args[j++].ToString();
                if (argStr.StartsWith(APP_KEY_PAIR_OPT_KEY))
                {
                    foundAppKeyPairOptKey = true;
                    // AppKeyPairMgrmethods will issue all appropriate status and/or error messages!
                    if ((!myAppKeyPairMgr.resolveAppKeyPairPath(argStr.Substring(APP_KEY_PAIR_OPT_KEY.Length)) ||
                        (!myAppKeyPairMgr.isValidCertificate())))
                    {
                        return;
                    }
                }
                else
                {
                    MySession.myConsole.printf("\tCall target name %d: %s%n", k++, argStr);
                    callTgtList.Add(argStr);
                }
            }
            if (!foundAppKeyPairOptKey)
            {
                // AppKeyPairMgrmethods will issue all appropriate status and/or error messages!
                if ((!myAppKeyPairMgr.resolveAppKeyPairPath()) ||
                    (!myAppKeyPairMgr.isValidCertificate()))
                {
                    return;
                }
            }

            myCallTargets = callTgtList.ToArray();

            MySession.myConsole.printf("%s: main - Creating session - Account = %s%n",
                    MY_CLASS_TAG, args[ACCOUNT_NAME_IDX]);
            mySession.doCreateSession(MY_CLASS_TAG, args[ACCOUNT_NAME_IDX], myAppKeyPairMgr.getPemFilePathname());

            MySession.myConsole.printf("%s: main - Logging in w/ password %s%n",
                    MY_CLASS_TAG, args[ACCOUNT_PWORD_IDX]);
            if (mySession.mySignInMgr.Login(MY_CLASS_TAG, mySession, args[ACCOUNT_PWORD_IDX]))
            {
                doMakeConferenceCall(mySession, myCallTargets);
                mySession.mySignInMgr.Logout(MY_CLASS_TAG, mySession);
            }
            // SkypeKitListeners, SignInMgr, and MySession will have logged/written
            // all appropriate diagnostics if login is not successful

            MySession.myConsole.printf("%s: Cleaning up...%n", MY_CLASS_TAG);
            if (mySession != null)
            {
                mySession.doTearDownSession();
            }
            MySession.myConsole.printf("%s: Done!%n", MY_CLASS_TAG);
        }


        /**
         * Conference with at least two other participants.
         * <ol>
         *   <li>Obtain the list of available playback and recording devices.</li>
         *   <li>Set the current devices (input, output, notification) to the first device
         *   	 in their respective list, and display their names.</li>
         *   <li>Create a conference conversation.</li>
         *   <li>Add each of the specified call targets (Skype Names) to the conversation as consumers.</li>
         *   <li>Obtain the resultant list of conversation participants, which will include
         * 		 the conference creator.</li>
         *   <li>Attempt to call each participant <em>except the conference creator</em>,
         *   	 and wait for them to answer.</li>
         *   <li>Wait until the call finishes.</li>
         * </ol>
         * 
         * @param mySession
         *	Populated session object
         * @param myCallTargets
         * 	The Skype Names of the people to conference with.
         * 
         * @since 1.0
         */
        static void doMakeConferenceCall(MySession mySession, String[] myCallTargets)
        {

            // Get available playback/recording devices; choose first of each
            if (mySession.setupAudioDevices(0, 0))
            {
                MySession.myConsole.printf("%s: Audio device set-up completed!%n", mySession.myTutorialTag);
            }
            else
            {
                MySession.myConsole.printf("%s: Audio device set-up failed - exiting!%n", mySession.myTutorialTag);
                return;
            }

            Conversation myConversation = (Conversation)mySession.mySkype.createConference();

            // *** DEBUG ***
            for (int m = 0; m < myCallTargets.Length; m++)
            {
                MySession.myConsole.printf("\tCall target name %d: %s%n", m, myCallTargets[m]);
            }

            myConversation.addConsumers(myCallTargets);

            Participant[] convParticipantList =
                myConversation.getParticipants(Conversation.ParticipantFilter.ALL);

            mySession.callActive = false;
            String partIdentity;
            int i;
            int j = convParticipantList.Length;
            int k = 0;
            for (i = 0; i < j; i++)
            {
                partIdentity = convParticipantList[i].getIdentity();

                if (partIdentity != mySession.myAccountName)
                {
                    k++;
                    MySession.myConsole.printf("Calling %s%n", partIdentity);
                    convParticipantList[i].ring(partIdentity, false, 1, 40, false,
                                                mySession.myAccount.getSkypeName());
                    int m = 0;
                    while ((m < SignInMgr.DELAY_CNT) && (!isRinging(convParticipantList[i])))
                    {
                        try
                        {
                            Thread.Sleep(SignInMgr.DELAY_INTERVAL);
                        }
                        catch (java.lang.InterruptedException e)
                        {
                            // TODO Auto-generated catch block
                            e.printStackTrace();
                        }
                        MySession.myConsole.printf("\t%d...%n", m++);
                    }

                    if (m >= SignInMgr.DELAY_CNT)
                    {
                        MySession.myConsole.printf("%s: Ring timed out for %s; skipping!%n",
                                MY_CLASS_TAG, convParticipantList[i]);
                        continue;
                    }
                    mySession.callActive = true;
                }
            }

            if (k == 0)
            {
                MySession.myConsole.println("No one (except maybe ourselves) to conference in ?!?");
                return;
            }

            while (!mySession.callActive)
            {
                try
                {
                    Thread.Sleep(SignInMgr.DELAY_INTERVAL);
                }
                catch (java.lang.InterruptedException e)
                {
                    // TODO Auto-generated catch block
                    e.printStackTrace();
                    return;
                }
            }
        }

        /**
         * <em>Dynamically</em> determine if a particular participant's "phone" is ringing.
         * 
         * @param participant
         * 	The target participant.
         * 
         * @return
         * <ul>
         *   <li>true: participant's phone is ringing</li>
         *   <li>false: participant's phone is <em>not</em> ringing</li>
         * </ul>
         * 
         * @since 1.0
         */
        public static bool isRinging(Participant participant)
        {

            MySession.myConsole.println("In isRinging!");

            if (participant == null)
            {
                return (false);
            }

            Participant.VoiceStatus voiceStatus = participant.getVoiceStatus();

            if (voiceStatus == Participant.VoiceStatus.RINGING)
            {
                return (true);
            }

            return (false);
        }
    }
}