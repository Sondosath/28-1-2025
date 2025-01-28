<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="seeBooks.aspx.cs" Inherits="_28_1_2025.seeBooks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
          <div>
      <div class="container mt-5">
      <h2>Books List</h2>
      <table class="table table-bordered">
          <thead>
              <tr>
                  <th>ID</th>
                  <th>Name</th>
                  <th>Kind</th>
                  <th>Level</th>
              </tr>
          </thead>
          <tbody id="booksTableBody" runat="server">
              <!-- Data will be dynamically populated here -->
          </tbody>
      </table>
  </div>
  </div>
    </form>
</body>
</html>
