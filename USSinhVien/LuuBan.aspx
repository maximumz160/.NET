<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/TrangXemDiem.Master" AutoEventWireup="true" CodeBehind="LuuBan.aspx.cs" Inherits="PROJECT_3.USSinhVien.LuuBan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="xemdiem" runat="server">
    <div id="nhap">NHẬP THÔNG TIN XEM DANH SÁCH SINH VIÊN LƯU BAN</div>
    <div id="khungnhap">
        <p>Mã Lớp: <select id="slmalop1" >
                    <option value="TK10.1">101121</option>
                    <option value="TK10.2">101122</option>
                    <option value="TK10.2">101123</option>
                </select>
           Tên Lớp:<input type="text" id="itenlop" value=""/>
        </p><br />
        <p>Năm học:<input type="text" id="inamhoc1" value="" />
        </p><br />
        <a href="#"><div id="xemdiem">Xem D/S</div></a>
    </div>
</asp:Content>
