# Zender <img class="emoji" alt="zap" height="20" width="20" src="https://assets-cdn.github.com/images/icons/emoji/unicode/26a1.png">
<p>Zender is a&nbsp;free&nbsp;email delivery service, it is built as Web API&nbsp;to serve marketers &amp;&nbsp;developers <span>and make it easy to send email. It is an email marketing solution.</span></p>
<p>You can use Zender to send unlimited emails</p>
<h2>We'd love your help making Zender better!</h2>
<p>There are a lot of ways you can contribute to making Zender better! You can report bugs and feature requests or ideally become an ongoing participant in the Zender Project community and contribute code to the open source project.</p>
<p>We enthusiastically welcome new contributors to the Zender Project <i><strong>even if you have no experience being part of an open source project</strong></i>. We've got some tips for new contributors and guides to getting started</p>
<h2>Follow these steps to start sending emails using .NET C#/VB.NET</h2>
<ol>
<li>First of all you need to get new API Key by registering & confirming your email in&nbsp;<a href="http://zender.sharptag.com">Zender</a></li>
<li>In your Visual Studio project, Install the package from&nbsp;<a href="https://www.nuget.org/packages/Zender.Mail/1.0.0">Nuget</a>. This package will add a reference to Zender.Mail in your .NET application. Zender.Mail is the client library that is built to consume Zender Web API&nbsp;<span>(Alternatively, you can also download and add the<em> Zender.Mail</em></span><em>.dll (1.0.0.0)</em><span>&nbsp;reference manually</span><span>):&nbsp;</span>
<blockquote>
<pre class="shell">PM&gt; install-package Zender.Mail</pre>
</blockquote>
</li>
<li>The code to send a new email:
<blockquote>
<pre class="shell">ZenderMessage message = new ZenderMessage("Your zender API Key");
MailAddress from = new MailAddress("yourmail@example.com");
MailAddress to = new MailAddress("tomail@example.com");
message.From = from;
message.To.Add(to);
message.Subject = "Welcome!";
message.Body = "&lt;p&gt;&lt;b&gt;Lorem ipsum&lt;/b&gt; dolor sit amet, consectetur adipiscing elit.&lt;/p&gt;";
message.IsBodyHtml = true;
message.SendMailAsync();
</pre>
</blockquote>
</li>
</ol>
