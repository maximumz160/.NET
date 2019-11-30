<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/TrangXemDiem.Master" AutoEventWireup="true" CodeBehind="TimKiemSinhVien.aspx.cs" Inherits="PROJECT_3.USSinhVien.TimKiemSinhVien" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="xemdiem" runat="server">
    <div id="nhap">NHẬP THÔNG TIN TÌM KIẾM SINH VIÊN</div>
    <div id="khungnhap">
        <p>Mã Lớp: <select id="slmalop" >
                    <option value="TK10.1">101121</option>
                    <option value="TK10.2">101122</option>
                    <option value="TK10.2">101123</option>
                </select>
           Tên Lớp:<input type="text" id="itenlop" value=""/>
        </p><br />
        <p>Mã SV: <select id="slmasv">
                    <option value="10112188">10112188</option>
                    <option value="10112151">10112151</option>
                   </select>
            Tên SV:<input type="text" id="itensv" value="" />
        </p><br />
        <a href="#"><div id="xemdiem">Xem thông tin</div></a>
    </div>
</asp:Content>
