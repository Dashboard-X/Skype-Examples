SkypeTalking
Versi�n 0.8
Copyright (c) 2010 Equipo SkypeTalking
Sitio web del proyecto: http://skypetalking.googlecode.com

1. Introducci�n

SkypeTalking es una utilidad que hace que Skype, un popular programa de telefon�a de Internet haga m�s f�cil el acceso a los ciego. Utiliza  la
API de Skype  y utiliza el lectores de pantalla y la salida en braille para obtener informaci�n de Skype y enviar esa informaci�n a su lector de pantalla. SkypeTalking
anunciar� la mayor�a de las alertas de Skype, incluyendo cambios de estado del usuario, entrada y salida de mensajes de chat, estados de llamada, y mucho
m�s! En resumen, SkypeTalking simplemente har� que Skype hable  por usted!
SkypeTalking fue desarrollado principalmente para NVDA, un lector de pantalla libre y abierto, para permitir el acceso  m�s NVDA a la aplicaci�n de Skype.
Sin embargo, tambi�n apoyar� JAWS, Window-Eyes, System Access y voces  SAPI5, aunque con SAPI5 no tendr� el soporte de braille.

1.1. Requisitos del sistema

Para utilizar SkypeTalking con �xito, se necesita lo siguiente:
* Windows 2000, XP, Vista o 7
* Cualquier lector de pantalla de apoyo: Actualmente los tipos soportados son los lectores de pantalla NVDA 2010.1 o posterior, JAWS (cualquier versi�n),
Window-Eyes (cualquier versi�n) o System Access (cualquier versi�n), incluyendo 
System Access to Go.
* Si usted no utiliza ninguno de los lectores de pantalla compatibles, una  voz SAPI5 se utilizar� en su lugar. En tal caso, usted debe tener las voces
SAPI5 compatible (sistemas de Windows cuentan con al menos una voz SAPI5 instalada)
* Y, por supuesto, la aplicaci�n cliente de Skype (3.x, 4.x o posterior) - es probable que funcione con Skype 2.x y posiblemente con 1.x, aunque no he probado.

2. C�mo utilizar

2.1. Instalaci�n y primera ejecuci�n

Para instalar SkypeTalking, inicie SkypeTalking_setup.exe y siga las instrucciones. La instalaci�n crear� un icono en el escritorio, un grupo de programas
en el men� de inicio, y la carpeta de instalaci�n se encuentran en x: \ SkypeTalking donde x es la letra de unidad del sistema.
Para desinstalar SkypeTalking, usted puede hacer esto mediante la apertura de grupo SkypeTalking programa en el men� Inicio y seleccione Desinstalar SkypeTalking.
Para iniciar SkypeTalking, haga clic en el icono SkypeTalking ya sea desde su escritorio o SkypeTalking entrada en un men� de inicio de los programas \
SkypeTalking.
Al iniciar SkypeTalking por primera vez, ser� probablemente no autorizado a comunicarse con la aplicaci�n Skype. Por razones de seguridad, Skype no permite
la activaci�n de cualquier  tercera parte  de plugins   y extras para comunicarse con �l sin permiso del usuario. Esto es para evitar que los virus y troyanos da�en Skype. Para
permitir el acceso SkypeTalking de Skype, haga lo siguiente:
1. Lanzar SkypeTalking, ya sea desde el escritorio o desde el men� de inicio bajo Programas> SkypeTalking. Que aqu� deben "conectarse a Skype".
2. Abrir Skype .
3. Ir a la barra de men�, seleccione Herramientas y, a continuaci�n flecha hacia arriba a las opciones y pulse Intro.
4. Flecha hacia abajo para la categor�a opciones avanzadas.
5. Pulse Shift + Tabulador varias veces hasta que caes en 
enlace "Administrar el acceso de otros programas a skype."
Presione la barra espaciadora para activarlo.
o Dan enter en ese enlace.
6. debe aparecer un cuadro de edici�n, que dice skypetalking.exe, en una lista (debe ser por lo general un primer elemento), Tabulan una vez para ir al bot�n Cambiar y presione la barra espaciadora para activarlo.
7. Presiona tab. Usted debe saber que se le coloca en un bot�n de radio que dice 
"No permitir el acceso a este programa a Skype". Flecha hacia arriba
hasta que escuche 
"Permitir el acceso a este programa a Skype" y presione Intro.
8. Voila! Usted acaba de permitir a SkypeTalking usar Skype! SkypeTalking ahora debe anunciar el mensaje de bienvenida. Ahora puede pulsar varias veces
Escape para salir de las opciones. Incluso no es necesario salvarlos.
Tenga en cuenta, tendr� que repetir estos pasos cada vez que vuelve a instalar SkypeTalking, pero no te preocupes, tienes que hacerlo s�lo una vez por
cada nueva instalaci�n de SkypeTalking . Usted tambi�n tendr� que hacerlo si hay un cambio en la ubicaci�n del archivo SkypeTalking.exe.

2.2. C�mo utilizar

Una vez lanzado, SkypeTalking se ejecutar� en un fondo y leer en voz alta las alertas hasta que lo cierre.
SkypeTalking tiene varios comandos asociados con los m�todos abreviados de teclado que puede utilizar para controlar el comportamiento de SkypeTalking
y obtener alguna informaci�n repetida o hablado. Todos los atajos de teclado son SkypeTalking en combinaci�n con Alt, Ctrl y Shift (Alt+Ctrl+SHIFT+Algo).
Por lo tanto podemos decir que Alt Ctrl Shift actua como un modificador SkypeTalking. As� que para ejecutar un comando, se mantiene Alt Ctrl + Shift (modificador SkypeTalking) y pulse cualquier tecla mientras se mantiene pulsado estas trez teclas.
Nota: Puede modificar todos los m�todos abreviados de teclado SkypeTalking a su gusto mediante la apertura de SkypeTalking.ini archivo ubicado en el directorio SkypeTalking, sin embargo se recomienda s�lo para usuarios avanzados en este momento.
En las secciones siguientes se describen todos los comandos SkypeTalking y c�mo usarlos.

3. Los comandos

3.1. Lectura de mensajes de chat de Skype

3.1.1. Habla los �ltimos 10  mensajes entrantes / salientes de chat (Alt+Ctrl+Shift+N�meros 1 a 0)

Mediante el uso de Alt+Ctrl+Shift +N�meros 1 a 0 en un teclado alfanum�rico, puede leer �ltima entrada y salida de mensajes de chat (del 1 al 10) que
ha recibido o enviado durante la sesi�n SkypeTalking. Si se pulsa dos veces, una copia del mensaje asociado a ese n�mero ira al portapapeles. Si se presiona
tres veces, se abrir� una direcci�n URL en el navegador web por defecto (si el mensaje contiene una direcci�n URL).

3.1.2. Vigilancia activa chats (Alt+Ctrl+Shift+Teclas de funci�n F1 a F10)

Esta caracter�stica le permite monitorear conversaciones activas, es decir, abrir ventanas de chat. Esto es �til si usted desea revisar s�lo �ltimos 10
mensajes de chat que est�n asociados a un determinado chat, chats, y no todos juntos. Utilice Alt Ctrl + Shift teclas de funci�n F1 a F10 para configurar
monitor a la una de hasta 10 chats activos (o pulse dos veces para concentrar la atenci�n a la ventana de chat), y entonces usted puede usar Alt Ctrl +
Shift N�meros para la lectura �ltimos 10 mensajes actualmente de chat supervisadas. Presionando Alt Ctrl + Shift C dar� a conocer la actualidad de chat
supervisadas, y pulsando dos veces a concentrar la atenci�n a la ventana de chat.

3.1.3. Repetir el �ltimo mensaje de chat (Alt Ctrl+Shift+R)

Este comando repite el �ltimo mensaje entrante o saliente de chat. Si se pulsa dos veces, se abrir� una ventana de chat de Skype asociadas con ese mensaje,
y tambi�n establecer� monitor de la charla a la misma.

3.2. Repetir el �ltimo evento (Alt+Ctrl+Shift+E)

Este comando  es para repitir el �ltimo evento Skype incluyendo mensajes de chat. Los acontecimientos que se puede repetir utilizando este comando incluyen cambios
de estado, el �ltimo mensaje de chat y los estados de llamada.

3.3. Ignorar los  eventos  de Skype bascular(Alt+Ctrl+Shift+I) 

Este comando cambiar� haciendo caso omiso de todos los eventos de Skype. Cuando est� activado, SkypeTalking simplemente ignora los acontecimientos y no
no los hablar� o no podra grabarlas.

3.4. Cambia tu estado de Skype al vuelo (Alt+Ctrl+Shift+tecla de Retroceso)

Utilice este comando para cambiar su estado de Skype al vuelo entre conectado, ausente, no disponible, no molestar, etc Su estado se cambi�� despu�s
de un segundo de soltar el comando.

3.5. Decir duraci�n de la llamada (Alt+Ctrl+Shift+D)

Este comando funciona durante una llamada de Skype, y el informa de la duraci�n de la llamada actual en horas, minutos y segundos.

3.6. Decir estado de la transferencia de archivos actual (Alt+Ctrl+Shift+F)

Este comando nos anuncia el estado de la transferencia del  archivos  ya �ltima entrada o salida. Si la transferencia de archivos actual est� en curso, tambi�n
se escuchar� la velocidad de transferencia actual en megabytes por segundo, y el n�mero de megabytes que actualmente se est�n transfiriendo.

3.7. El informe de su estado actual en l�nea o saldo acreedor (Alt+Ctrl+Shift+O)

Este comando cuando se pulsa una vez, nos dice  el estado de conexi�n actual, y si se pulsa dos veces nos dice el saldo actual de nuestro cr�dito de Skype.

3.8. Informe o cambia tu estado de �nimo de Skype de texto (Alt+Ctrl+Shift+M)

Este comando nos dice el actual estado de �nimo de texto de su Skype enel caso  que se 
establece. Si se pulsa dos veces, se abrir� un cuadro de di�logo que
le permite introducir un nuevo texto del estado de �nimo. A continuaci�n, puede introducir un texto nuevo, y entonces usted puede simplemente pulsar Intro
cuando haya terminado. Su estado de �nimo de texto ser� cambiado.

3.9. Otros comandos

3.9.1. El cuadro de di�logo Acerca de SkypeTalking (Alt+Ctrl+ Shift+A)

Este cuadro de di�logo muestra la versi�n actual de SkypeTalking, la informaci�n de copyright, la informaci�n del sitio web etc, Usted puede cerrar esta ventana pulsando
enter.

3.9.2. Informe de la versi�n de Skype (Alt+Ctrl+Shift+V)

Este comando nos dice la versi�n  que est� ejecutando de Skype instalado en el ordenador del usuario. Si se pulsa dos veces, nos dice la versi�n de la API Skype 
(sobre todo �til para los desarrolladores).

3.9.3.  Parar voz SAPI5 (Alt+Ctrl+Shift+Barra espaciadora)

Este comando detendr� la voz cuando habla SkypeTalking, est� se utiliza con la voz SAPI5. Si est�s utilizando SkypeTalking con su lector de pantalla, usted
puede parar la voz como de costumbre, presionando la tecla Ctrl.

3.9.4. Salir SkypeTalking (Alt+Ctrl+Shift+Q)

Este comando descarga SkypeTalking de la memoria. De forma predeterminada, se le pedir� confirmaci�n. Si su respuesta es S�, SkypeTalking se descarga,
y cualquier evento pasado, la transferencia de archivos actuales y mensajes de chat ser� olvidado desde SkypeTalking los mantiene en la memoria del equipo
y por lo tanto se eliminan de la memoria una vez SkypeTalking se descarga. Si su respuesta es No, SkypeTalking seguir� trabajando en �l es actual per�odo
de sesiones.

4. El di�logo de Configuraci�n

el di�logo de configuraci�n SkypeTalking se puede invocar pulsando Alt+Ctrl+Shift+P 
(de preferencias). Se puede utilizar para cambiar el comportamiento de
SkypeTalking, y tambi�n su lengua que viene por defecto y la salida de voz.
El di�logo de configuraci�n tiene tres pesta�as (General, de salida y alertas) que se puede cambiar mediante el uso de las teclas est�ndares de Windows es decir,  pulsando las teclas Ctrl+Tab 
o pulsando las teclas Ctrl+Shift+Tab 

4.1. pesta�a General

La pesta�a General de SkypeTalking que se encuentra en el di�logo  de configuraci�n tiene las siguientes opciones.

4.1.1. El lenguaje

El lenguaje cuadro combinado muestra todos los idiomas disponibles que son compatibles actualmente con SkypeTalking. Aqu� usted puede elegir su idioma
preferido, y se aplica inmediatamente despu�s de guardar la configuraci�n. De forma predeterminada, SkypeTalking utiliza el lenguaje utilizado por el sistema
operativo.

4.1.2. Inicio autom�tico de Skype si no se ejecuta

Esta opci�n en caso que est� la casilla verificada permitir� a SkypeTalking para lanzar autom�ticamente el programa Skype para usted si se olvida de poner en marcha antes de ejecutar Skypecon SkypeTalking. Esto tambi�n es �til si desea ejecutar Skype y tener un acceso instant�neo a los anuncios de Skype. Esta opci�n est� activada de forma predeterminada,
lo que significa que SkypeTalking cargar� Skype si detecta que Skype no se est� ejecutando.

4.1.3. Confirmar al salir SkypeTalking

Esta opci�n est� activada de forma predeterminada. Si se desactiva, SkypeTalking se descargar� inmediatamente tan pronto como se emite el comando Salir
y el mensaje de confirmaci�n se omiten.

4.1.4. Al salir de SkypeTalking, tambi�n se sale de Skype

Esta opci�n esta en  auto-descripci�n. Est� marcada por defecto, lo que significa que al salir de SkypeTalking, tambi�n descargara Skype para usted. Sin embargo,
si desea seguir utilizando Skype despu�s de salir de SkypeTalking sin descargar Skype, es probable que desee desactivar esta opci�n.

4.2. Pesta�a Salida

La pesta�a de salida contiene los ajustes relacionados con la salida de la voz y la salida en braille. Aqu� se pueden establecer las siguientes opciones.

4.2.1. Voz de salida

La caja de salida de voz combo que permite ajustar su salida de voz preferida. Si selecciona Auto Detect, que detecta autom�ticamente y utilizar el lector
de pantalla en ejecuci�n, o SAPI5 si su lector de pantalla no se est� ejecutando o no por SkypeTalking. Si se establece en SAPI5, autom�ticamente usar�
una voz SAPI5 y no har� caso de su lector de pantalla.

4.2.2. Velocidad de voz SAPI5

Los 3 siguientes controles que se encuentran en un cuadro de edici�n  con las que usted puede controlar el volumen y tipo de voz de su sintetizador SAPI5 en el caso cuando
se utiliza SAPI5. Usted puede utilizar las teclas de flecha para ajustar los valores o escriba un n�mero deseado.

4.2.3. Habilitar salida Braille

Esta casilla de verificaci�n le permite decidir que le gustar�a ver SkypeTalking de salida en la pantalla en braille. Esta opci�n no funciona con SAPI5.

4.3. Pesta�a de las alertas

Esta pesta�a le permite activar y desactivar los anuncios de varias alertas de Skype en la actualidad con el apoyo de SkypeTalking. Cualquier cosa sin marcar
aqu� ser� ignorado por SkypeTalking. Puede cambiar los anuncios de los chats entrantes, salientes chats, los estados de l�nea, etc

5. El Administrador de Contactos

El Administrador de Contactos de SkypeTalking le permite ver y gestionar tus contactos de Skype en una manera f�cil y accesible. Puede acceder a ella pulsando el atajo de teclado 
Alt+Ctrl+Shift+F11 del teclado. Si se pulsa dos veces este comando, SkypeTalking se centrar� en el foco de la ventana original de la lista de los contactos Skype. 

5.1. Navegando Administrador de Contactos

El Administrador de Contactos SkypeTalking muestra los contactos en una lista de selecci�n de caja m�ltiple , lo que le permite seleccionar uno o m�s contactos a
realizar algunas acciones en. Utiliza las teclas de flecha para navegar entre tus contactos, y utiliza la barra espaciadora para alternar en contacto con la
actualidad centrada entre seleccionados y no seleccionados. El Administrador de Contactos tambi�n muestra el estado de los contactos, el texto del estado
de �nimo, y la �ltima fecha y la hora de ver los contactos en l�nea.

5.2. Elegir un recurso de contacto seleccionado

�Qu� acciones se muestra en Administrador de Contactos depende del n�mero de contactos seleccionados.
Si no hay contactos se seleccionan, SkypeTalking nos anuncia un mensaje de advertencia.
Si s�lo se selecciona un contacto, las siguientes acciones est�n disponibles:
1. Bot�n de llamada - realiza una llamada de Skype para el contacto seleccionado - Este es el bot�n predeterminado, por lo que pulsar Intro cuando se centra
en una lista de contactos, �ste se activa
2. Bot�n Chat  - Abre una ventana de chat con el contacto seleccionado
3. Perfil - Abre un visor de perfiles de Administrador de Contactos
Si los contactos de dos o m�s est�n seleccionados, las acciones disponibles son las siguientes:
1. Bot�n Crear Conferencia - Crea una conferencia con todos los contactos seleccionados - Este es el bot�n predeterminado, por lo que al pulsar Intro cuando
se centra en una lista de contactos, �ste se activa
2.  Bot�n Crear multi-chat abre una ventana de chat y crea un multichat con todos los contactos seleccionados
Usted puede utilizar el tabulador y las teclas Shift+Tabulador para navegar entre las acciones y una lista de contactos. Pulse la tecla Esc o activar
el bot�n Cancelar en cualquier momento para cerrar el Administrador de Contactos.

5.3. El Visor de perfil

El Visor de perfil es una parte del Administrador de Contactos que se abrir� cuando se activa el bot�n Ver perfil de un contacto individual. Se muestra
el perfil de los detalles del contacto seleccionado en un formato accesible y f�cil de usar cuadro de di�logo. Utilice Tab y Shift+Tab para mover la ficha
de detalle a detalle, y entonces usted puede usar las teclas de flecha y la selecci�n de todos los comandos de texto est�ndar de copiar alg�n detalle en
particular si lo desea. Para cerrar el Visor de perfil, active el bot�n Cancelar o presione Escape para volver al Administrador de Contactos.

6. Env�o y recepci�n de mensajes SMS con SkypeTalking

SkypeTalking le permite enviar y recibir mensajes SMS en una forma f�cil con su asistente integrado SMS.

6.1. El Asistente para SMS

Usted puede tener acceso con el Asistente  SMS pulsando Alt+Ctrl+Shift+S.

Una vez abierto, se le pedir� que introduzca un n�mero de tel�fono. Debe introducir un n�mero de tel�fono v�lido aqu�, incluyendo un c�digo de pa�s. Por
ejemplo: 11234567. Si el n�mero no es v�lido, se vuelve de nuevo al campo de n�mero de tel�fono para  volver hacer una nueva tentativa entrando de nuevo un n�mero. Pulse Intro
para continuar, o presione Escape para cancelar.
Si el n�mero de tel�fono era v�lido, el asistente continuar� y se le colocar� en un �rea de edici�n donde se debe redactar el mensaje SMS. Mientras que
en este cuadro de di�logo, puede pulsar la tecla de funci�n F2 en cualquier momento para obtener el estado actual de sus mensajes SMS 
que est� componiendo. Un pitido de aviso se escuchar� en el caso cuando el n�mero de caracteres que quedan en un mensaje llega a 0.
Una vez que haya compuesto el mensaje SMS, puede pulsar Tab para ir al bot�n Enviar y hacer Intro para enviarlo o el bot�n Cancelar para cancelar el env�o. Si el bot�n
Enviar se activa, y el saldo de su cr�dito es bueno, el SMS se envi�.

7. la informaci�n final y los datos de contacto

7.1. La obtenci�n de un c�digo fuente

SkypeTalking es software libre y de c�digo abierto, escrito en un lenguaje de programaci�n Python disponible en www.python.org. El c�digo abierto significa
que el c�digo fuente del software est� disponible para cualquiera que lo desee. SkypeTalking usa GNU Licencia P�blica General versi�n 2.0. Usted puede
leer la licencia completa en el archivo license.txt que viene con SkypeTalking.
Si usted es un programador, o si desea contribuir a un c�digo fuente o se puede ejecutar SkypeTalking directamente desde la fuente, se puede visitar un
repositorio SVN de SkypeTalking que se encuentran en
http://skypetalking.googlecode.com
sitio del proyecto web. All� tambi�n se puede descargar la �ltima versi�n.

7.2. Contribuir con una traducci�n

Si usted es un traductor y quieres localizar SkypeTalking y la documentaci�n en su propio idioma, puede ponerse en contacto conmigo v�a un e-mail en ingl�s para recibir
las �ltimas novedades de archivo de idioma y las instrucciones para que luego me pued� enviar de vuelta sus traducciones. Tambi�n si usted tiene alg�n
conocimiento de la subversi�n usando repositorio, estar� encantado de darle los derechos de acceso para actualizar la traducci�n de vez en cuando.

7.3. La lista de correo SkypeTalking

Usted puede unirse a  la lista de SkypeTalking escribiendo al correo  que esta alojado en los Grupos de Google utilizando la siguiente direcci�n: subscribe@googlegroups.com skypetalking.
Para enviar un correo electr�nico a la lista de discusi�n de SkypeTalking utilice la direcci�n skypetalking@googlegroups.com Tenga en cuenta que esta lista s�lo es en  Ingl�s hablante.

Este es el mejor recurso para obtener apoyo t�cnico y varios consejos y trucos sobre SkypeTalking. Aqu� tambi�n recibir� una informaci�n diaria sobre
lo que est� pasando con SkypeTalking en  desarrollo  de repositorio. Todas las preguntas son bienvenidas, desde las preguntas  de los principiante hasta las preguntas   de los avanzado.

7.4. Cr�ditos

Las siguientes personas han contribuido al desarrollo de SkypeTalking de alguna manera:
- Hrvoje Kati�, que es el tipo principal del proyecto SkypeTalking .
- Gianluca Casalino, quien ha desarrollado diversas funciones avanzadas de SkypeTalking, y ha contribuido mucho al trabajo para los c�digos SkypeTalking. Gracias
a su dedicaci�n y ayuda, SkypeTalking es a�n mucho mejor que antes!
- Ren� Linke, que tambi�n contribuye a SkypeTalking de alguna manera mediante la creaci�n de parches y dando ideas iniciales.
- Varias gentes relajadas  que han hecho SkypeTalking disponibles en sus propios idiomas, por lo que SkypeTalking ahora habla m�s de 15 idiomas!
- Y, por supuesto, todos los usuarios de todo el mundo que est�n utilizando SkypeTalking en una base diaria y hacen su promoci�n para que la gente m�s sepa  
acerca de este producto!
Muchas gracias a todos Ustedes!

7.5. Mi informaci�n para ponerse en contacto

Mi E-Mail para preguntas, sugerencias, apoyo y anunciar una traducci�n : hrvojekatic@gmail.com
Me puedes seguir en Twitter en: www.twitter.com / hkatic
Mi p�gina de Facebook: www.facebook.com/jukebox2009
Mi Id Klango en klango.net: DJ_Jukebox
Mi direcci�n de MSN: hrkatic@hotmail.com
Mi Skype: hrvojekatic

Fin del documento.