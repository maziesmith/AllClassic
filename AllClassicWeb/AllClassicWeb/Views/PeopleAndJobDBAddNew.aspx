﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PeopleAndJobDBAddNew.aspx.cs" Inherits="AllClassicWeb.Views.PeopleAndJobDBAddNew" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="//cdnjs.cloudflare.com/ajax/libs/bootstrap-datetimepicker/4.17.37/css/bootstrap-datetimepicker.css" rel="stylesheet" />
    <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.js"></script>
    <script src="//cdnjs.cloudflare.com/ajax/libs/moment.js/2.15.2/moment.min.js"></script>
    <script src="//cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.3.7/js/bootstrap.js"></script>
    <script src="//cdnjs.cloudflare.com/ajax/libs/bootstrap-datetimepicker/4.17.37/js/bootstrap-datetimepicker.min.js"></script>

    <h4>New Data Input</h4>
    <hr />

    <div class="row">

        <div class="col-xs-4" style="padding: 0;">
            <div class="col-xs-4"><%=Resources.DisplayText.PeopleOrJob %>*</div>
            <div class="col-xs-6" style="padding: 0;">
                <asp:DropDownList ID="DropDownList1_type" runat="server" class="form-control" OnDataBound="DropDownList1_type_DataBound">
                                                            <asp:ListItem Value="-1" Text="<%$Resources:DisplayText,Job %>"></asp:ListItem>
                                                            <asp:ListItem Value="-2" Text="<%$Resources:DisplayText,People %>"></asp:ListItem>
                                                        </asp:DropDownList>

            </div>
        </div>
        <div class="col-xs-4" style="padding: 0;">
            <div class="col-xs-4"><%=Resources.DisplayText.ValidDate %>*</div>
            <div class="col-xs-6" style="padding: 0;">
                <div class='input-group date' id='datetimepicker2' style="display: flex;">
                    <input type='text' class="form-control" runat="server"  ValidationGroup="a"  onchange="selectedFilterChanged"   id="datetimefilter" style="display: inline-block; border-right-width: 0px;" />
                    <span class="input-group-addon" style="flex-wrap: wrap; width: auto; display: inline-block; padding-left: 12px; margin-left: -5px; padding-top: 9px; padding-bottom: 6px;">
                        <span class="glyphicon glyphicon-calendar"></span>
                    </span>
                </div>
                <asp:RequiredFieldValidator Display="Dynamic" runat="server" ForeColor="IndianRed" ValidationGroup="a" Font-Bold="true" ID="RequiredFieldValidator2" ControlToValidate="datetimefilter" ErrorMessage="<%$Resources:DisplayText,PleasefillValidDatefield %>" />

            </div>
        </div>
        <div class="col-xs-4" style="padding: 0;">
            <div class="col-xs-4"><%=Resources.DisplayText.Title %>*</div>
            <div class="col-xs-6" style="padding: 0;">
                <asp:TextBox runat="server" ID="txt_title" CssClass="form-control"  ValidationGroup="a" />
                <asp:RequiredFieldValidator Display="Dynamic" runat="server" ForeColor="IndianRed" ValidationGroup="a" Font-Bold="true" ID="RequiredFieldValidator1" ControlToValidate="txt_title" ErrorMessage="<%$Resources:DisplayText,Pleasefilltitlefield %>" />

            </div>
        </div>

    </div>

    <br />
    <div class="row">

        <div class="col-xs-4" style="padding: 0;">
            <div class="col-xs-4"><%=Resources.DisplayText.City %>*</div>
            <div class="col-xs-6" style="padding: 0;">
                <asp:DropDownList ID="DropDownList3_city" runat="server" class="form-control" AutoPostBack="false" DataSourceID="SqlDataSource1_city" DataTextField="SubCode" DataValueField="LookUpID" OnDataBound="DropDownList3_city_DataBound"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1_city" runat="server" ConnectionString="<%$ ConnectionStrings:AllClassicDBConnectionString %>" SelectCommand="SELECT LookUpID, MainCode, SubCode 
FROM Main.LookUpTbl
where maincode='City'
"></asp:SqlDataSource>
            </div>
        </div>
        <div class="col-xs-4" style="padding: 0;">
            <div class="col-xs-4"><%=Resources.DisplayText.ContactName %>*</div>
            <div class="col-xs-6" style="padding: 0;">
                <asp:TextBox runat="server" ID="txt_contactname"  ValidationGroup="a" CssClass="form-control" />
                <asp:RequiredFieldValidator Display="Dynamic" runat="server" ForeColor="IndianRed" ValidationGroup="a" Font-Bold="true" ID="RequiredFieldValidator3" ControlToValidate="txt_contactname" ErrorMessage="<%$Resources:DisplayText,PleasefillContactNamefield %>" />

            </div>
        </div>
        <div class="col-xs-4" style="padding: 0;">
            <div class="col-xs-4"><%=Resources.DisplayText.TelNo %>*</div>
            <div class="col-xs-6" style="padding: 0;">
                <asp:TextBox runat="server" ID="txt_telno" CssClass="form-control"  ValidationGroup="a" />
                <asp:RequiredFieldValidator Display="Dynamic" runat="server" ForeColor="IndianRed" ValidationGroup="a" Font-Bold="true" ID="RequiredFieldValidator4" ControlToValidate="txt_telno" ErrorMessage="<%$Resources:DisplayText,PleasefillTelNofield %>" />

            </div>
        </div>

    </div>


    <br />

    <div class="row">

        <div class="col-xs-4" style="padding: 0;">
            <div class="col-xs-4"><%=Resources.DisplayText.Email %>*</div>
            <div class="col-xs-6" style="padding: 0;">
                <asp:TextBox runat="server" ID="txt_email" TextMode="Email" CssClass="form-control"  ValidationGroup="a" />
                <asp:RequiredFieldValidator Display="Dynamic" runat="server" ForeColor="IndianRed" ValidationGroup="a" Font-Bold="true" ID="RequiredFieldValidator5" ControlToValidate="txt_email" ErrorMessage="<%$Resources:DisplayText,PleaseenteryourEmail %>" />

            </div>
        </div>

    </div>

    <br />
    <div class="row">

        <div class="col-xs-12" style="padding: 0;">
            <div class="col-xs-12 form-group">
                <div><%=Resources.DisplayText.Description %>*</div>
                <asp:TextBox runat="server" ID="txt_description"  ValidationGroup="a" CssClass="form-control" TextMode="MultiLine" Rows="10" style="max-width:500px;" />
                <asp:RequiredFieldValidator Display="Dynamic" runat="server" ForeColor="IndianRed" ValidationGroup="a" Font-Bold="true" ID="RequiredFieldValidator6" ControlToValidate="txt_description" ErrorMessage="<%$Resources:DisplayText,PleasefillDescriptionfield %>" />

            </div>
        </div>

    </div>

    <br />

    <div class="row col-md-4 col-xs-4">
        <asp:Button Visible="true" ID="btn_PeopleAndJob_cancel" CssClass="btn btn-danger pull-right" runat="server" Text="<%$Resources:DisplayText,Cancel %>" OnClick="btn_PeopleAndJob_cancel_Click" Style="margin-right: 10px;" />
        <asp:Button Visible="false" ID="btn_PeopleAndJob_save" CssClass="btn btn-warning pull-right" runat="server" ValidationGroup="a"   Text="<%$Resources:DisplayText,Update %>" OnClick="btn_PeopleAndJob_save_Click" Style="margin-right: 10px;" />
        <asp:Button ID="btn_PeopleAndJob_add" Visible="false" CssClass="btn btn-primary pull-right" ValidationGroup="a"  runat="server" Text="<%$Resources:DisplayText,Add %>" OnClick="btn_PeopleAndJob_add_Click" Style="margin-right: 10px;" />

    </div>


    <script type="text/javascript">
        function bindDateTime() {
            $('#datetimepicker2').datetimepicker({
                format: 'MM/DD/YYYY'
            });
        }
        $(function () {
            $('#datetimepicker2').datetimepicker({
                format: 'MM/DD/YYYY'
            });
        });
    </script>

</asp:Content>
