<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/TrangXemDiem.Master" AutoEventWireup="true" CodeBehind="TimKiemMonHoc.aspx.cs" Inherits="PROJECT_3.USSinhVien.TimKiemMonHoc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="xemdiem" runat="server">
    <div id="nhap">NHẬP THÔNG TIN TÌM KIẾM MÔN HỌC</div>
    <div id="khungnhap">
        <p>Học kỳ : <select id="slmasv">
                    <option value="">1</option>
                    <option value="">2</option>
                   </select>
            Năm học :<select id="slnamhoc">
                    <option value=""></option>
                   </select>
        </p><br />
        <p>Mã môn: <select id="slmalop" >
                    <option value=""></option>
                </select>
           Tên môn :<input type="text" id="itenlop" value=""/>
        </p><br />
        <a href="#"><div id="xemdiem">Xem thông tin</div></a>
    </div>
</asp:Content>
