<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/TrangXemDiem.Master" AutoEventWireup="true" CodeBehind="TimKiemLop.aspx.cs" Inherits="PROJECT_3.USSinhVien.TimKiemLop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="xemdiem" runat="server">
        <div id="nhap">NHẬP THÔNG TIN TÌM KIẾM LỚP</div>
    <div id="khungnhap">
        <p>
            Chuyên ngành: <select id="slchuyennganh" >
                    <option value="mem">Công nghệ phần mềm</option>
                    <option value="mang">Mạng máy tính và truyền thông</option>
                    <option value="cung">Công nghệ máy tính</option>
                </select>
        </p><br />
        <p>Mã Lớp: <select id="slmalop1" >
                    <option value="TK10.1">101121</option>
                    <option value="TK10.2">101122</option>
                    <option value="TK10.2">101123</option>
                </select>
           Tên Lớp:<input type="text" id="itenlop" value=""/>
        </p><br />
        <a href="#"><div id="xemdiem">Xem thông tin</div></a>
    </div>
</asp:Content>
