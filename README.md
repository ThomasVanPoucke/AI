<h1>AI</h1>

The purpose of this application is to answer to things you say.

You can side-load this app to a Windows 10 installation (phone or desktop). Cortana needs to be enabled.

Once you've clicked the button to start listening she will start to respond. 
She will check continuously if she needs to respond to something you said.
She has a constrained list of sentences on which she reponds. Because this list is limited her speech recognition abilities are better than Cortana.

I've already added responses for these sentences:
<ul>
<li>Hello Sara, How are you?</li>
<li>I love your companie.</li>
<li>Nice to meet you.</li> 
<li>What are your hobbies?</li>
<li>You don't need to be so rude!</li>
</ul>

You can extend this list.
The file <b>Strings/en-US/interaction.resw</b> contains 2 kind of key-value pairs. The ones ending with .question are the things
you can say to Sara.
For each <i>.question</i> there is a corresponding <i>.answer</i> record. This <i>.answer</i> contains Sara's response.
E.g. the <i>howareyou.question</i> record has a corresponding <i>howareyou.answer</i> with the response of Sare.

In case you want to extend this application:
<ul>
<li>All communication with Interaction.resw should go via InteractionManager.cs</li>
<li>I used the Cortana api. The magic happens at MainPage.xaml.cs</li>
<li>Unit tests can be added to the <i>AIUnitTest project</i>.</li>
</ul>


