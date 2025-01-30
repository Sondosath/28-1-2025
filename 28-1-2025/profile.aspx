<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="_28_1_2025.profile" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Profile</title>
    <link href="https://fonts.googleapis.com/css2?family=Abel&family=Montserrat:wght@300&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">
    <style>
       * {
    padding: 0;
    margin: 0;
    box-sizing: border-box;
}

body {
    top: 50%;
    left: 50%;
    position: absolute;
    transform: translate(-50%, -50%);
}

.container {
    height: 450px;
    width: 300px;
    box-shadow: 0 10px 20px black;
    background-size: cover;
    justify-content: center;
    align-items: center;
    text-align: center;
    overflow: hidden;
    font-family: 'Abel', sans-serif;
}

.image {
    height: 100px;
    width: 100px;
    background-image: url('https://xp.io/storage/15pewlWA.jpg');
    background-size: cover;
    border-radius: 50%;
    border: 8px solid white;
    position: relative;
    top: 200px;
    margin-left: 170px;
    box-shadow: 0 2px 15px rgb(58, 54, 54);
    transform: rotate(-20deg);
}

.shape {
    height: 250px;
    width: 400px;
    background-color: black;
    margin-left: -20px;
    position: relative;
    top: -80px;
    box-shadow: 0 2px 15px black;
    transform: rotate(25deg);
}

h3 {
    margin-bottom: 10px;
    font-family: 'Montserrat', sans-serif;
}

.title {
    color: rgb(105, 100, 109);
}

p {
    padding-left: 30px;
    padding-right: 30px;
    color: rgb(105, 100, 109);
}

.icons {
    margin-top: 15px;
}

.icons i {
    margin-left: 10px;
    font-size: 20px;
    transition: 0.3s;
    color: rgb(40, 163, 194);
    ;
}

.icons i:hover {
    transform: scale(1.1);
    color: rgb(18, 192, 235);
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="shape">
                <div class="image"></div>
            </div>
            <!-- Server-side Labels to Display User Data -->
            <h3><asp:Label ID="lblName" runat="server" Text=""></asp:Label></h3>
            <h3 class="title"><asp:Label ID="lblEmail" runat="server" Text=""></asp:Label></h3>
             <asp:Button ID="editProfile" runat="server" OnClick="editProfile_Click" text="Edit" > </asp:Button>               

        </div>
    </form>
</body>
</html>
