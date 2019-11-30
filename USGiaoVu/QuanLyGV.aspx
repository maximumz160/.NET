<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/QuanLyThongTin.Master" AutoEventWireup="true" CodeBehind="QuanLyGV.aspx.cs" Inherits="PROJECT_3.USGiaoVu.QuanLyGV" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="qlthongtin" runat="server">
    <div id="quanly">QUẢN LÝ THÔNG TIN GIẢNG VIÊN</div>
    <div id="khungql">
        <table id="bangqlgv">
            <tr>
                <td>Mã GV:</td>
                <td><input type="text" id="txtMaGV" value="" maxlength="8"/></td>
            </tr>
            <tr>
                <td>Tên GV:</td>
                <td><input type="text" id="txtTenGV" value=""/></td>
            </tr>
            <tr>
                <td>Ảnh:</td>
                <td><input type="text" id="txtAnhGV" value=""/></td>
            </tr>
            <tr>
                <td>Khoa:</td>
                <td><input type="text" id="txtkhoa" value="" maxlength="6"/></td>
            </tr>
            <tr>
                <td>Giới tính:</td>
                <td><select id="slgioitinhgv">
                    <option value="">Nam</option>
                    <option value="">Nữ</option>
                    <option value="">Khác</option>
                   </select>
                </td>
            </tr>
            <tr>
                <td colspan="2">Ngày sinh:
                    <input type="text" id="txtNgaySinhGV" value="Ngày"/>
                    <select id="slthangGV"><option value="">Tháng 1</option><option value="">Tháng 2</option><option value="">Tháng 3</option><option value="">Tháng 4</option><option value="">Tháng 5</option><option value="">Tháng 6</option><option value="">Tháng 7</option><option value="">Tháng 8</option><option value="">Tháng 9</option><option value="">Tháng 10</option><option value="">Tháng 11</option><option value="">Tháng 12</option></select>
                    <input type="text" id="txtNamGV" value="Năm"/>
                </td>
            </tr>
            <tr>
                <td>Quê quán:</td>
                <td><input type="text" id="txtQueQuanGV" value=""/></td>
            </tr>
            <tr>
                <td>Số điện thoại:</td>
                <td><input type="text" id="txtSDTGV" value=""/></td>
            </tr>
            <tr>
                <td>Email:</td>
                <td><input type="text" id="txtMailGV" value=""/></td>
            </tr>
        </table> 
        <div id="themsv">Thêm</div>
    </div>
</asp:Content>
