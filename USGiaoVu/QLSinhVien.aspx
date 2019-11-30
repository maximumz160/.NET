<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/QuanLyThongTin.Master" AutoEventWireup="true" CodeBehind="QLSinhVien.aspx.cs" Inherits="PROJECT_3.USGiaoVu.QLSinhVien" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="qlthongtin" runat="server">
    <div id="quanly">QUẢN LÝ THÔNG TIN SINH VIÊN</div>
    <div id="khungql">
        <table id="bangqlsv">
            <tr>
                <td>Mã SV:</td>
                <td><input type="text" id="txtMasv" value="" maxlength="8"/></td>
            </tr>
            <tr>
                <td>Tên SV:</td>
                <td><input type="text" id="txtTensv" value=""/></td>
            </tr>
            <tr>
                <td>Ảnh:</td>
                <td><input type="text" id="txtAnh" value=""/></td>
            </tr>
            <tr>
                <td>Mã lớp:</td>
                <td><input type="text" id="txtMaLop" value="" maxlength="6"/></td>
            </tr>
            <tr>
                <td>Giới tính:</td>
                <td><select id="slgioitinh">
                    <option value="">Nam</option>
                    <option value="">Nữ</option>
                    <option value="">Khác</option>
                   </select>
                </td>
            </tr>
            <tr>
                <td colspan="2">Ngày sinh:
                    <input type="text" id="txtNgaySinh" value="Ngày"/>
                    <select id="slthang"><option value="">Tháng 1</option><option value="">Tháng 2</option><option value="">Tháng 3</option><option value="">Tháng 4</option><option value="">Tháng 5</option><option value="">Tháng 6</option><option value="">Tháng 7</option><option value="">Tháng 8</option><option value="">Tháng 9</option><option value="">Tháng 10</option><option value="">Tháng 11</option><option value="">Tháng 12</option></select>
                    <input type="text" id="txtNam" value="Năm"/>
                </td>
            </tr>
            <tr>
                <td>Quê quán:</td>
                <td><input type="text" id="txtQueQuan" value=""/></td>
            </tr>
            <tr>
                <td>Số điện thoại:</td>
                <td><input type="text" id="txtSDT" value=""/></td>
            </tr>
            <tr>
                <td>Email:</td>
                <td><input type="text" id="txtMail" value=""/></td>
            </tr>
        </table> 
        <div id="themgv">Thêm</div>
    </div>
</asp:Content>
