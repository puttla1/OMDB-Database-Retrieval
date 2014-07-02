<%@ 
Page Language="C#" Inherits="Sample2.Default"
 
%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html>
<head runat="server">

 	<link rel="stylesheet" href="Public/jquery.flipster.min.css">

	<title>Movie Search</title>
 
</head>
<body>

 	<script src="//ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js"></script>
	<script>window.jQuery || document.write('<script src="/js/jquery-1.10.2.min.js"><\/script>')</script>
	<script src="Public/jquery.flipster.min.js"></script>

	<script language="javascript" type="text/javascript">
		$(function(){ $('.flipster').flipster(); });
	</script>

	<script language="javascript" type="text/javascript">
		$( "#Image" ).click(function() {
 			 alert( "Handler for .click() called." );
		});

	</script>

	<form id="form1" runat="server"> 

		Movie Search: <input id="tb1"  type="text" name="firstname" runat="server"/> 
		<asp:Button id="button1" runat="server" Text="Click this" OnClick="button1Clicked" /> <br />

		<asp:Label id="ErrorString" runat="server"/> 

	 
		<div class="flipster">
			<ul class="flip-items">
	        		<li id="Item1" style="display:none" title="Item 1 Title"  runat="server">
	            		<img id="Image" onclick="Image.style.display='none';Firstitem.style.display='block';" runat="server" />

	            		<span id="Firstitem" style="display:none" onclick="Firstitem.style.display='none';document.getElementById('Image').style.display = 'block';" runat="server">
								<asp:Label id="Name" runat="server" Style="display:block"/> 
								<asp:Label id="Date_Released" runat="server" Style="display:block"/> 
								<asp:Label id="Rating" runat="server" Style="display:block"/> 
								<asp:Label id="Runtime" runat="server" Style="display:block"/> 
								<asp:Label id="Genre" runat="server" Style="display:block"/>
								<asp:Label id="Summary" runat="server" Style="display:block"/> 
								<asp:Label id="CRating" runat="server"/>  <meter style="display: none" id="Meter" min="0" max="10" runat="server">Percent</meter>
	            		</span>
	        		</li>

	        		<li id="Item2" style="display:none" title="Item 2 Title"  runat="server">
	            		<img id="Image2"  onclick="Image2.style.display='none';Firstitem2.style.display='block';" runat="server" />

	            		<span id="Firstitem2" style="display:none" onclick="Firstitem2.style.display='none';document.getElementById('Image2').style.display = 'block';" runat="server">
	            				<asp:Label id="Shown2" runat="server" Style="display:block"/>
								<asp:Label id="Name2" runat="server" Style="display:block"/> 
								<asp:Label id="Date_Released2" runat="server" Style="display:block"/> 
								<asp:Label id="Rating2" runat="server" Style="display:block"/> 
								<asp:Label id="Runtime2" runat="server" Style="display:block"/> 
								<asp:Label id="Genre2" runat="server" Style="display:block"/>
								<asp:Label id="Summary2" runat="server" Style="display:block"/> 
								<asp:Label id="CRating2" runat="server"/>  <meter style="display: none" id="Meter2" min="0" max="10" runat="server">Percent</meter>
	            		</span>
	        		</li>

	        		<li id="Item3" style="display:none" title="Item 3 Title"  runat="server">
	            		<img id="Image3"  onclick="Image3.style.display='none';Firstitem3.style.display='block';" runat="server" />

	            		<span id="Firstitem3" style="display:none" onclick="Firstitem3.style.display='none';document.getElementById('Image3').style.display = 'block';" runat="server">
	            				<asp:Label id="Shown3" runat="server" Style="display:block"/>
								<asp:Label id="Name3" runat="server" Style="display:block"/> 
								<asp:Label id="Date_Released3" runat="server" Style="display:block"/> 
								<asp:Label id="Rating3" runat="server" Style="display:block"/> 
								<asp:Label id="Runtime3" runat="server" Style="display:block"/> 
								<asp:Label id="Genre3" runat="server" Style="display:block"/>
								<asp:Label id="Summary3" runat="server" Style="display:block"/> 
								<asp:Label id="CRating3" runat="server"/>  <meter style="display: none" id="Meter3" min="0" max="10" runat="server">Percent</meter>
	            		</span>
	        		</li>

	        		<li id="Item4" style="display:none" title="Item 4 Title"  runat="server">
	            		<img id="Image4"  onclick="Image4.style.display='none';Firstitem4.style.display='block';" runat="server" />

	            		<span id="Firstitem4" style="display:none" onclick="Firstitem4.style.display='none';document.getElementById('Image4').style.display = 'block';" runat="server">
	            				<asp:Label id="Shown4" runat="server" Style="display:block"/>
								<asp:Label id="Name4" runat="server" Style="display:block"/> 
								<asp:Label id="Date_Released4" runat="server" Style="display:block"/> 
								<asp:Label id="Rating4" runat="server" Style="display:block"/> 
								<asp:Label id="Runtime4" runat="server" Style="display:block"/> 
								<asp:Label id="Genre4" runat="server" Style="display:block"/>
								<asp:Label id="Summary4" runat="server" Style="display:block"/> 
								<asp:Label id="CRating4" runat="server"/>  <meter style="display: none" id="Meter4" min="0" max="10" runat="server">Percent</meter>
	            		</span>
	        		</li>


	        		<li id="Item5" style="display:none" title="Item 5 Title"  runat="server">
	            		<img id="Image5"  onclick="Image5.style.display='none';Firstitem5.style.display='block';" runat="server" />

	            		<span id="Firstitem5" style="display:none" onclick="Firstitem5.style.display='none';document.getElementById('Image5').style.display = 'block';" runat="server">
	            				<asp:Label id="Shown5" runat="server" Style="display:block"/>
								<asp:Label id="Name5" runat="server" Style="display:block"/> 
								<asp:Label id="Date_Released5" runat="server" Style="display:block"/> 
								<asp:Label id="Rating5" runat="server" Style="display:block"/> 
								<asp:Label id="Runtime5" runat="server" Style="display:block"/> 
								<asp:Label id="Genre5" runat="server" Style="display:block"/>
								<asp:Label id="Summary5" runat="server" Style="display:block"/> 
								<asp:Label id="CRating5" runat="server"/>  <meter style="display: none" id="Meter5" min="0" max="10" runat="server">Percent</meter>
	            		</span>
	        		</li>

	        		<li id="Item6" style="display:none" title="Item 6 Title"  runat="server">
	            		<img id="Image6"  onclick="Image6.style.display='none';Firstitem6.style.display='block';" runat="server" />

	            		<span id="Firstitem6" style="display:none" onclick="Firstitem6.style.display='none';document.getElementById('Image6').style.display = 'block';" runat="server">
	            				<asp:Label id="Shown6" runat="server" Style="display:block"/>
								<asp:Label id="Name6" runat="server" Style="display:block"/> 
								<asp:Label id="Date_Released6" runat="server" Style="display:block"/> 
								<asp:Label id="Rating6" runat="server" Style="display:block"/> 
								<asp:Label id="Runtime6" runat="server" Style="display:block"/> 
								<asp:Label id="Genre6" runat="server" Style="display:block"/>
								<asp:Label id="Summary6" runat="server" Style="display:block"/> 
								<asp:Label id="CRating6" runat="server"/>  <meter style="display: none" id="Meter6" min="0" max="10" runat="server">Percent</meter>
	            		</span>
	        		</li>

	        		<li id="Item7" style="display:none" title="Item 7 Title"  runat="server">
						<img id="Image7"  onclick="Image7.style.display='none';Firstitem7.style.display='block';" runat="server" />

						<span id="Firstitem7" style="display:none" onclick="Firstitem7.style.display='none';document.getElementById('Image7').style.display = 'block';" runat="server">
								<asp:Label id="Shown7" runat="server" Style="display:block"/>
								<asp:Label id="Name7" runat="server" Style="display:block"/> 
								<asp:Label id="Date_Released7" runat="server" Style="display:block"/> 
								<asp:Label id="Rating7" runat="server" Style="display:block"/> 
								<asp:Label id="Runtime7" runat="server" Style="display:block"/> 
								<asp:Label id="Genre7" runat="server" Style="display:block"/>
								<asp:Label id="Summary7" runat="server" Style="display:block"/> 
								<asp:Label id="CRating7" runat="server"/>  <meter style="display: none" id="Meter7" min="0" max="10" runat="server">Percent</meter>
						</span>
					</li>

					<li id="Item8" style="display:none" title="Item 8 Title"  runat="server">
						<img id="Image8"  onclick="Image8.style.display='none';Firstitem8.style.display='block';" runat="server" />

						<span id="Firstitem8" style="display:none" onclick="Firstitem8.style.display='none';document.getElementById('Image8').style.display = 'block';" runat="server">
								<asp:Label id="Shown8" runat="server" Style="display:block"/>
								<asp:Label id="Name8" runat="server" Style="display:block"/> 
								<asp:Label id="Date_Released8" runat="server" Style="display:block"/> 
								<asp:Label id="Rating8" runat="server" Style="display:block"/> 
								<asp:Label id="Runtime8" runat="server" Style="display:block"/> 
								<asp:Label id="Genre8" runat="server" Style="display:block"/>
								<asp:Label id="Summary8" runat="server" Style="display:block"/> 
								<asp:Label id="CRating8" runat="server"/>  <meter style="display: none" id="Meter8" min="0" max="10" runat="server">Percent</meter>
						</span>
					</li>

			  </ul>
		</div>
	</form> 
</body>
</html>
