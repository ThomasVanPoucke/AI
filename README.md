<h1>AI</h1>

The purpose of this application is to answer to things you say.

I've called the voice that responds to what you say 'Sara'.

You can side-load this app to a Windows 10 installation (phone or desktop). Cortana needs to be enabled.

Once you've clicked the button to start listening she will continuously listen to all sounds. 
You don't have to say 'Hey Cortana' or anything to let her know that you are addressing her.
She uses a constrained list of things on which she will respond in order to have a better voice recognition experience than the
default Cortana.

I've already added some things on which she will respond:
Hello Sara, How are you?, 
I love your companie, 
Nice to meet you, 
What are your hobbies?, 
You don't need to be so rude!

You can extend this list with the following instruction.
The file <b>Strings/en-US/interaction.resw</b> contains 2 kind of key-value pairs. The ones ending with .question are the things
you can say to Sara.
For each question there is a corresponding .answer record. This contains the response of Sara.
E.g. the howareyou.question record has a corresponding howareyou.answer with the response of Sare.

In case you want to extend this application:

<li>All communication with Interaction.resw should go via InteractionManager.cs</li>
<li>The voice recognition can be found inside MainPage.xaml.cs</li>
<li>Unit tests can be added to the AIUnitTest project.</li>


