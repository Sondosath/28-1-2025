<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserCards.aspx.cs" Inherits="_28_1_2025.UserCards" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div style="display:flex;gap:10px; justify-content:space-evenly;">
                    <div><br /><br /><br />
            <div class="card" style="width: 18rem;">
              <img src="https://i.pinimg.com/736x/ea/62/87/ea6287544591f5321a299a8519d8b304.jpg" class="card-img-top" alt="...">
              <div class="card-body">
                <h5 class="card-title">see Books</h5>
               
        <asp:Button runat="server" ID="seeBooks" OnClick="seeBooks_Click" Text="see Books"  class="btn btn-primary"></asp:Button>
              </div>
            </div>
        </div>
        <div><br /><br /><br />
    <div class="card" style="width: 18rem;">
      <img src="https://i.pinimg.com/736x/ea/62/87/ea6287544591f5321a299a8519d8b304.jpg" class="card-img-top" alt="...">
      <div class="card-body">
        <h5 class="card-title">see meeting room</h5>
       
        <asp:Button runat="server" ID="seeMeetingRoom" OnClick="seeMeetingRoom_Click" Text="see meeting room" href="#" class="btn btn-primary"></asp:Button>
      </div>
    </div>
</div>
        
        </div>
    </form>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>

</body>
</html>
