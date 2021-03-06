﻿using System;
using Skypekit.NET;
using com.skype.api;

namespace Tutorial10
{
    /**
 * Copyright (C) 2010, 2011 Skype Limited
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
 * Getting Started With SkypeKit. Tutorial Application, Step 10.
 * 
 * This example illustrates a simple SkypeKit-based program that:
 * <ol>
 *   <li>Takes a Skype Name, password, and
 *       optional AppKeyPair PEM file pathname as command-line arguments</li>
 *   <li>Initiates login for that user</li>
 *   <li>Waits until the login process is complete</li>
 *	 <li>Creates an HTML fragment that can be used to join public chats
 * 	     by clicking on a Web page.</li>
 *   <li>Initiates logout</li>
 *   <li>Waits until logout is complete</li>
 *   <li>Cleans up and exits</li>
 * 
 * @author Andrea Drane (ported from existing C++ tutorial code)
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
        public static String MY_CLASS_TAG = "Tutorial_10";

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
         * Number of required arguments in the command line argument list.
         * 
         * @since 1.0
         */
        public static int REQ_ARG_CNT = 2;

        /**
         * Number of <em>optional</em> arguments in the command line argument list.
         * 
         * @since 1.0
         */
        public static int OPT_ARG_CNT = 1;

        /**
         * Index of the <em>optional</em> AppKeyPair PEM file pathname in
         * the command line argument list, which is always last.
         * 
         * @since 1.0
         */
        public static int APP_KEY_PAIR_IDX = ((REQ_ARG_CNT + OPT_ARG_CNT) - 1);

        private static AppKeyPairMgr myAppKeyPairMgr = new AppKeyPairMgr();
        private static MySession mySession = new MySession();

        /**
         * Main loop
         * 
         * @param args
         * <ol>
         *   <li>Name of the target Skype account.</li>
         *   <li>Password for the target Skype account.</li>
         *   <li>Pathname of a PEM file.</li>
         * </ol>
         * 
         * @since 1.0
         */
        public static void Main(String[] args)
        {

            if (args.Length < REQ_ARG_CNT)
            {
                MySession.myConsole.printf("Usage is %s accountName accountPassword [appTokenPathname]%n%n", MY_CLASS_TAG);
                return;
            }
            if (args.Length > (REQ_ARG_CNT + OPT_ARG_CNT))
            {
                MySession.myConsole.printf("%s: Ignoring %d extraneous arguments.%n", MY_CLASS_TAG, (args.Length - REQ_ARG_CNT));
            }

            // Ensure our certificate file name and contents are valid
            if (args.Length > REQ_ARG_CNT)
            {
                // AppKeyPairMgrmethods will issue all appropriate status and/or error messages!
                if ((!myAppKeyPairMgr.resolveAppKeyPairPath(args[APP_KEY_PAIR_IDX])) ||
                    (!myAppKeyPairMgr.isValidCertificate()))
                {
                    return;
                }
            }
            else
            {
                if ((!myAppKeyPairMgr.resolveAppKeyPairPath()) ||
                    (!myAppKeyPairMgr.isValidCertificate()))
                {
                    return;
                }
            }

            MySession.myConsole.printf("%s: main - Creating session - Account = %s%n",
                                MY_CLASS_TAG, args[ACCOUNT_NAME_IDX]);
            mySession.doCreateSession(MY_CLASS_TAG, args[ACCOUNT_NAME_IDX], myAppKeyPairMgr.getPemFilePathname());

            MySession.myConsole.printf("%s: main - Logging in w/ password %s%n",
                    MY_CLASS_TAG, args[ACCOUNT_PWORD_IDX]);
            if (mySession.mySignInMgr.Login(MY_CLASS_TAG, mySession, args[ACCOUNT_PWORD_IDX]))
            {
                doPublicChat(mySession);
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
         * Join a conversation.
         * <ol>
         *   <li>Creates a conference conversation.</li>
         *   <li>Establishes its properties to enable joining as a SPEAKER with history visible.</li>
         *   <li>Obtains the conversation's join BLOB.</li>
         *   <li>Writes the href for joining the conversation to the console.</li>
         * </ol> 
         * 
         * @param mySession
         *	Populated session object
         * 
         * @since 1.0
         */
        static void doPublicChat(MySession mySession)
        {

            Conversation myConversation;

            if ((myConversation = mySession.mySkype.createConference()) != null)
            {
                // NB! Setting chat options must be done before asking for a join BLOB.
                myConversation.setOption(Conversation.Property.P_OPT_JOINING_ENABLED.getId(), 1);
                myConversation.setOption(Conversation.Property.P_OPT_ENTRY_LEVEL_RANK.getId(), Participant.Rank.SPEAKER.getId());
                myConversation.setOption(Conversation.Property.P_OPT_DISCLOSE_HISTORY.getId(), 1);

                String convBlob;
                if ((convBlob = myConversation.getJoinBlob()) != null)
                {
                    MySession.myConsole.printf("You can copy/paste the following HTML link and use it in a Web page to join Public Chat:%n%n");
                    MySession.myConsole.printf("<a href=\"skype:?chat&blob=%s\">Click here.</a>%n%n", convBlob);
                    MySession.myConsole.printf("Note that the creator of this chat - %s - needs to be online for you to actually join.%n", mySession.myAccountName);
                }
                else
                {
                    MySession.myConsole.printf("%s: Unable to retrieve join BLOB from conversation.%n", mySession.myTutorialTag);
                }
            }
            else
            {
                MySession.myConsole.printf("%s: Unable to create conversation.%n", mySession.myTutorialTag);
            }
        }
    }
}