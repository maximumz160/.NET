<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/TrangXemDiem.Master" AutoEventWireup="true" CodeBehind="TimKiemGv.aspx.cs" Inherits="PROJECT_3.USSinhVien.TimKiemGv" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="xemdiem" runat="server">
        <div id="nhap">NHẬP THÔNG TIN TÌM KIẾM GIẢNG VIÊN</div>
    <div id="khungnhap">
        <p>
            Khoa: <select id="slkhoa" >
                    <option value=""></option>
                    <option value=""></option>
                    <option value=""></option>
                </select>
        </p><br />
        <p>Mã GV: <select id="slgv1" >
                    <option value=""></option>
                    <option value=""></option>
                    <option value=""></option>
                </select>
           Tên GV:<input type="text" id="itenlop" value=""/>
        </p><br />
        <a href="#"><div id="xemdiem">Xem thông tin</div></a>
    </div>
</asp:Content>
