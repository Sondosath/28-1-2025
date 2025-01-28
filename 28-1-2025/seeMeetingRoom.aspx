<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="seeMeetingRoom.aspx.cs" Inherits="_28_1_2025.seeMeetingRoom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
          <div>
      <div class="container mt-5">
      <h2>Meeting Rooms</h2>
      <table class="table table-bordered" style="border:solid 2px black">
          <thead style="border:solid 2px black;">
              <tr  style="border:solid 2px black;" >
                  <th  style="border:solid 2px black;">ID</th>
                  <th  style="border:solid 2px black;">Name</th>
                  <th style="border:solid 2px black;">Location</th>
                  <th  style="border:solid 2px black;">Capacity</th>
              </tr>
          </thead>
          <tbody id="booksTableBody" runat="server" style="border:solid 2px black;">
              <!-- Data will be dynamically populated here -->
          </tbody>
      </table>
  </div>
  </div>
    </form>
</body>
</html>
