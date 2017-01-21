<h1>AI</h1>

The purpose of this application is to answer to things you say.

You can side-load this app to a Windows 10 installation (phone or desktop). Cortana needs to be enabled.

Once you've clicked the button to start listening she will start to respond. 
You don't have to say 'Hey Cortana' or anything. She will listen continuously.
She uses a constrained list of things on which she will respond. Because the list on things on which will repsond is limited her speech recognition abilities are better than Cortana.

I've already added some things on which she will respond:
<ul>
<li>Hello Sara, How are you?</li>
<li>I love your companie.</li>
<li>Nice to meet you.</li> 
<li>What are your hobbies?</li>
<li>You don't need to be so rude!</li>
</ul>

You can extend this list with the following instruction.
The file <b>Strings/en-US/interaction.resw</b> contains 2 kind of key-value pairs. The ones ending with .question are the things
you can say to Sara.
For each question there is a corresponding .answer record. This contains the response of Sara.
E.g. the howareyou.question record has a corresponding howareyou.answer with the response of Sare.

In case you want to extend this application:
<ul>
<li>All communication with Interaction.resw should go via InteractionManager.cs</li>
<li>The voice recognition can be found inside MainPage.xaml.cs</li>
<li>Unit tests can be added to the AIUnitTest project.</li>
</ul>


