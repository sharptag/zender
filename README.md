# zender
<p>Zender is a&nbsp;free&nbsp;email delivery service, it is built as Web API&nbsp;to serve marketers &amp;&nbsp;developers <span>and make it easy to send email. It is an email marketing solution.</span></p>
<p>You can use Zender to send unlimited emails</p>
<p><span style="text-decoration: underline;"><strong>How to consume the Web API</strong></span>&nbsp;&nbsp;</p>
<ol>
<li>First of all you need to install the package from&nbsp;<a href="https://www.nuget.org/packages/Zender.Mail/1.0.0">Nuget</a>. This package will add a reference to Zender.Mail in your .NET application. Zender.Mail is the client library that is built to consume Zender Web API&nbsp;<span>(Alternatively, you can also download and add the<em> Zender.Mail</em></span><em>.dll (1.0.0.0)</em><span>&nbsp;reference manually</span><span>):&nbsp;</span>
<blockquote>
<pre class="shell">PM&gt; install-package Zender.Mail</pre>
</blockquote>
</li>
<li>Get new API Key by registering your email in&nbsp;<a href="http://zender.sharptag.com">Zender</a></li>
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
