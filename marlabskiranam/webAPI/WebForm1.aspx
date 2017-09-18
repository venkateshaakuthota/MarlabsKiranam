<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="webAPI.WebForm1" %>

<!DOCTYPE html>
<script src="https://code.jquery.com/jquery-3.2.1.min.js">
    function GetStudentById() {
        $.ajax({
            type: "GET",
            url: "http://localhost/webAPI/api/Student/1",
            contentType: "json",
            dataType: "json",
            success: function (data) {
                //stringify
                var jsonData = JSON.stringify(data);
                //Parse JSON
                var objData = $.parseJSON(jsonData);
                var objData = $.parseJSON(jsonData);
                var id = objData.StudentId;
                var fname = objData.FirstName;
                var lname = objData.LastName; $('<tr><td>' + id + '</td><td>' + fname +
                    '</td><td>' + lname + '</td></tr>').appendTo('#students');
            },
            error: function (xhr) {
                alert(xhr.responseText);
            }
        });
    }
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <table border='1' id="students">
     <!-- Make a Header Row -->
        <tr>
            <td><b>StudentID</b></td>
            <td><b>FirstName</b></td>
            <td><b>LastName</b></td>
        </tr>
    </table>
</body>
</html>
