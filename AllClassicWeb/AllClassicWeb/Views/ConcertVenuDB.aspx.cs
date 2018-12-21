﻿using DataAccessP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AllClassicWeb.Views
{
    public partial class ConcertVenuDB : System.Web.UI.Page
    {

        static UserTbl user;
        protected void Page_Load(object sender, EventArgs e)
        {
            user = (UserTbl)Session["User"];

        }

        public void onclick_btn_addNewConcertVenu(object sender, EventArgs e)
        {
            if (user != null)
            {
                Session["ConcertVenuID"] = null;
                Session["updateConcertVenu"] = false;
                Response.Redirect("ConcertVenuDBAddNew.aspx");
            }
            else showMsg(Resources.DisplayText.Pleasesignintocontinue);
        }



        public void collegeListContainer_OnItemDataBound(object sender, ListViewItemEventArgs e)
        {
            var editbutton = (LinkButton)e.Item.FindControl("edit");
            var deletebutton = (LinkButton)e.Item.FindControl("delete");
            var stringvalueOFUserid = DataBinder.Eval(e.Item.DataItem, "UserID").ToString();
            if (user != null & stringvalueOFUserid.Length!=0)
            {
                int userID = int.Parse(DataBinder.Eval(e.Item.DataItem, "UserID").ToString().Trim());
                if (user.UserID == userID || user.IsMasterUser == 1) { editbutton.Visible = true; deletebutton.Visible = true; }
                else { editbutton.Visible = false; deletebutton.Visible = false; }
            }
            else { editbutton.Visible = false; deletebutton.Visible = false; }

        }

        public void showMsg(string msg)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + msg + "')", true);
        }
        public void editvenuClicked(object sender, CommandEventArgs e)
        {

            Session["ConcertVenuID"] = e.CommandArgument.ToString();
            Session["updateConcertVenu"] = true;
            Response.Redirect("ConcertVenuDBAddNew.aspx");
        }
         
        [System.Web.Services.WebMethod]
        [System.Web.Script.Services.ScriptMethod()]
        public static bool DeleteVenu(int n)
        {
            return BusinessLogic.VenuLogic.deleteVenu(n);
        }

        public void selectedFilterChanged(object sender, EventArgs ee)
        {

            var filterQuery = "";
            if (DropDownList1_cityfilter.SelectedIndex != 0) filterQuery += " where city like N'%" + DropDownList1_cityfilter.SelectedItem.Value + "%'";
            if (txtbox_namefilter.Text.ToString().Length > 0)
            {
                if (DropDownList1_cityfilter.SelectedIndex != 0) filterQuery += " And ";
                else filterQuery += " Where ";

                filterQuery += " Name like N'%" + txtbox_namefilter.Text.ToString() + "%'";
            }
            if (txtbox_aliasfilter.Text.ToString().Length > 0)
            {
                if (DropDownList1_cityfilter.SelectedIndex != 0 || txtbox_namefilter.Text.ToString().Length > 0) filterQuery += " And ";
                else filterQuery += " Where ";

                filterQuery += " Alias like N'%" + txtbox_aliasfilter.Text + "%'";
            }

            SqlDataSource1_Collegelist.SelectCommand = string.Format(@"select r.*, r.EmailID, ci.SubCode as cityname,u.UserID from Auxiliary.VenueTbl r
            left join Main.usertbl u on r.Userid=u.userid
               left join(SELECT LookUpID, MainCode, SubCode 
            FROM Main.LookUpTbl
            where maincode='City' ) ci on ci.LookUpID=r.City" + filterQuery + @"
                order by UpdateTimeStamp desc");

            collegeListContainer.DataBind();
        }



    }
}