<%@ Page Title="Videos" Language="C#" MasterPageFile="~/USERMASTER/umaster.Master" AutoEventWireup="true" CodeBehind="Videos.aspx.cs" Inherits="AARAATOURS.USERMASTER.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <center>
       <table width="1400px" style="font-weight: bold; background-color: #FFCCFF">
          <!-- <thead><h1>Our City Map </h1></thead> -->
           <br /><br />
              <h2 class="heading-agileinfo text-center pb-4">City <span>Map</span></h2>

           <style>
               /* Style the table cells */
		td {
			padding: 10px;
			border: 1px solid black;
			vertical-align: top;
		}

        /* Style the list */
		ul {
			list-style: none;
			padding: 0;
			margin: 0;
		}

        h3{
            font-size:16px;
            font-weight: bold;
        }
        
		/* Style the list items */
		li {
			margin-bottom: 20px;
			display: flex;
			align-items: center;
		}

		/* Style the image in the list */
		li img {
			width: 300px;
			height: 180px;
			margin-right: 20px;
            margin-left: 60px;
		}
           </style>

          	<tr>
			<td>
				<ul>

                    <li>
                        <pre>
                            <h3>karadiyana Garbage Dump</h3>
                             <p>Garbage Dump - Karadiyana Rd</p>
                             
                        </pre>
                            <img src="images/q1.jpg">
                    </li><hr>

                    <li>
                        <pre>
                            <h3>Katunayeka Seeduwa Urban <br /> Council Dump Yard</h3>
                             <p>Garbage Dump - E03</p>
                        </pre>
                            <img src="images/q2.jpg">
                    </li><hr>

                    <li>
                        <pre>
                            <h3>Western Provincial Waste <br /> Management Authority</h3>
                             <p>Government Office - 32 Sir <br /> Marcus Fernando Mawatha</p>
                        </pre>
                            <img src="images/q4.jpg">
                    </li><hr>

                    <li>
                        <pre>
                            <h3>Deldorawatta Garbage <br /> Recycling Center</h3>
                             <p>Garbage Dump</p>
                        </pre>
                            <img src="images/q5.jpg">
                    </li><hr>

                  
				
				</ul>
			</td>
			
            <td style="width: 60%">
                 <div id="map-container"</div>
                <style>
                    #map-container {
			        height: 500px;
			        border: 1px solid black;
		            }
                </style>

                <div class="mapouter">
                    <div class="gmap_canvas">
                        <iframe class="gmap_iframe" frameborder="0" scrolling="no" marginheight="0" marginwidth="0"
                            src="https://maps.google.com/maps?width=900&amp;height=890&amp;hl=en&amp;q=colombo&amp;t=k&amp;z=14&amp;ie=UTF8&amp;iwloc=B&amp;output=embed">

                        </iframe>

                    </div>
                    <style>
                        .mapouter{position:relative;
                                  text-align:right;
                                  width:900px;
                                  height:890px;

                        }
                        .gmap_canvas {overflow:hidden;
                                      background:none!important;
                                      width:900px;
                                      height:890px;

                        }
                        .gmap_iframe {width:900px!important;
                                      height:890px!important;

                        }</style>

                </div>


            </td>
        </tr>
       </table>
   </center>

 



</asp:Content>
