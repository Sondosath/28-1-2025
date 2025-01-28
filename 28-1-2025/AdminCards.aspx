<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminCards.aspx.cs" Inherits="_28_1_2025.AdminCards" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
                <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">

</head>
<body>
    <form id="form1" runat="server">
        <div style="display:flex; justify-content:center;">
        <div>
            <div class="card" style="width: 18rem;">
              <img src="https://i.pinimg.com/736x/ea/62/87/ea6287544591f5321a299a8519d8b304.jpg" class="card-img-top" alt="...">
              <div class="card-body">
             
                <p class="card-text">Add Books</p>
        <asp:Button runat="server" ID="AddBooks" OnClick="AddBooks_Click" Text="Add Books"  class="btn btn-primary"></asp:Button>
              </div>
            </div>
        </div>
        <div>
<%--    <div class="card" style="width: 18rem;">
      <img src="https://i.pinimg.com/736x/ea/62/87/ea6287544591f5321a299a8519d8b304.jpg" class="card-img-top" alt="...">
      <div class="card-body">
       
        <p class="card-text">Add Room</p>
        <asp:Button runat="server" ID="AddRoom" OnClick="AddRoom_Click" Text="Add Rooms"  class="btn btn-primary"></asp:Button>
      </div>
     </div>--%>
    </div>
        <div>
    <div class="card" style="width: 18rem;">
      <img src="https://i.pinimg.com/736x/ea/62/87/ea6287544591f5321a299a8519d8b304.jpg" class="card-img-top" alt="...">
      <div class="card-body">
        
        <p class="card-text">Show books </p>
        <asp:Button runat="server" ID="Showbooks" OnClick="Showbooks_Click" Text="Show books"  class="btn btn-primary"></asp:Button>
      </div>
    </div>
</div>
            </div>
    </form>
   <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>

</body>
</html>
