<%@ Page Title="Tours Booking" Language="C#" MasterPageFile="~/USERMASTER/umaster.Master" AutoEventWireup="true" CodeBehind="ToursBooking.aspx.cs" Inherits="AARAATOURS.USERMASTER.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

	<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">


     <!-- promotions -->
	<section class="wthree-row w3-about py-lg-5">
		<div class="container py-5">
            <div class="title-section pb-sm-5 pb-3">
               <h3 class="heading-agileinfo text-center pb-4">Report To <span> Incidents Place</span></h3>
            </div>

			      <div class="card-deck">

				   
				 <div class="card">
					       <img src="images/g2.jpg" class="img-fluid" alt="Card image cap">
					   <div class="card-body w3ls-card">

					 <center><h5 class="card-title">Colombo</h5>
					  <p class="card-text mb-3"><i class="fas fa-map-marker pr-2"></i>Colombo</p>
					  <p class="card-text mb-3"><i class="fa fa-area-chart pr-2"></i>18 km2</p>
					 </center> 
						    <br />
						<center><a href="#" class="btn btn-primary">ADD INCIDENT</a></center>
						   <br />
					  <center>
                          <asp:Button ID="Button5" runat="server" Text="FIND LOCATION" OnClick="btn_book1_Click"  />
					  </center>
					</div>
				  </div>

				  <div class="card">
					       <img src="images/g2.jpg" class="img-fluid" alt="Card image cap">
					   <div class="card-body w3ls-card">

					  <center><h5 class="card-title">Dehiwala</h5>
					  <p class="card-text mb-3"><i class="fas fa-map-marker pr-2"></i>Mount Lavinia </p>
					  <p class="card-text mb-3"><i class="fa fa-area-chart pr-2"></i>8 km2</p>
					 </center> 
						    <br />
						<center><a href="#" class="btn btn-primary">ADD INCIDENT</a></center>
						   <br />
					  <center>
                          <asp:Button ID="Button1" runat="server" Text="FIND LOCATION" OnClick="btn_book1_Click"  />
					  </center>
					</div>
				  </div>

				<div class="card">
					       <img src="images/g3.jpg" class="img-fluid" alt="Card image cap">
					   <div class="card-body w3ls-card">

				 <center><h5 class="card-title">Homagama</h5>
					  <p class="card-text mb-3"><i class="fas fa-map-marker pr-2"></i>Homagama </p>
					  <p class="card-text mb-3"><i class="fa fa-area-chart pr-2"></i>121 km2</p>
					 </center> 
						    <br />
						<center><a href="#" class="btn btn-primary">ADD INCIDENT</a></center>
						   <br />
					  <center>
                          <asp:Button ID="Button2" runat="server" Text="FIND LOCATION" OnClick="btn_book1_Click"  />
					  </center>
					</div>
				  </div>

				<div class="card">
					       <img src="images/g4.jpg" class="img-fluid" alt="Card image cap">
					   <div class="card-body w3ls-card">
					 
						    <center><h5 class="card-title">Kaduwela</h5>
					  <p class="card-text mb-3"><i class="fas fa-map-marker pr-2"></i>Kaduwela </p>
					  <p class="card-text mb-3"><i class="fa fa-area-chart pr-2"></i>88 km2</p>
					 </center> 
						    <br />
						<center><a href="#" class="btn btn-primary">ADD INCIDENT</a></center>
						   <br />
					  <center>
                          <asp:Button ID="Button3" runat="server" Text="FIND LOCATION" OnClick="btn_book1_Click"  />
					  </center>
					</div>
				  </div>

				<div class="card">
					       <img src="images/g5.jpg" class="img-fluid" alt="Card image cap">
					   <div class="card-body w3ls-card">
					
						    <center><h5 class="card-title">Kesbewa</h5>
					  <p class="card-text mb-3"><i class="fas fa-map-marker pr-2"></i>Kesbewa </p>
					  <p class="card-text mb-3"><i class="fa fa-area-chart pr-2 "></i>64 km 2</p>
					 </center> 
						    <br />
						<center><a href="#" class="btn btn-primary">ADD INCIDENT</a></center>
						   <br />
					  <center>
                          <asp:Button ID="Button4" runat="server" Text="FIND LOCATION" OnClick="btn_book1_Click"  />
					  </center>
					</div>
				  </div>


			</div>
            </div>
        </section>
<!-- //promotions -->






</asp:Content>
