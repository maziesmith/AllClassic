﻿using DataAccessP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AllClassicWeb
{
    public partial class QADbNew : System.Web.UI.Page
    {

        static UserTbl user;
        protected void Page_Load(object sender, EventArgs e)
        {
            user = (UserTbl)Session["User"];

        }

        public void onclick_btn_addNew(object sender, EventArgs e)
        {
            Response.Redirect("QADbAddNew.aspx");
        }



        protected void ParentRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            AllClassicDBEntities entities = new AllClassicDBEntities();
            var detail = (Repeater)e.Item.FindControl("FirstChildRepeater");
            int parentID = ((AnswersTbl)e.Item.DataItem).AnswerID;
            detail.DataSource = entities.AnswersTbls.Where(x => x.ParentAnswer == parentID).ToList();
            detail.DataBind();


            //var FirstChildRepeater = (Repeater)item.FindControl("FirstChildRepeater");
            //FirstChildRepeater.DataSource = entities.AnswersTbls.Where(x => x.AnswerID == answer.AnswerID).ToList();
            //FirstChildRepeater.DataBind();

            //RepeaterItem item = e.Item;
            //if ((item.ItemType == ListItemType.Item) ||
            //    (item.ItemType == ListItemType.AlternatingItem))
            //{
            //    var detail = (Repeater)item.FindControl("FirstChildRepeater");
            //    int parentID = ((PerformanceCommentTbl)e.Item.DataItem).CommentID;
            //    detail.DataSource = CommentLogic.getCommentsByParentCommentID(parentID);
            //    detail.DataBind();

            //}
        }

        protected void collegeListContainer_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            ListViewItem item = e.Item;

            int questionID = int.Parse(DataBinder.Eval(e.Item.DataItem, "QuestionID").ToString());
             
            var detail = (Repeater)item.FindControl("ParentRepeater");

            AllClassicDBEntities entities = new AllClassicDBEntities();
            detail.DataSource = entities.AnswersTbls.Where(x => x.QuestionID == questionID).ToList();
            try
            {
                detail.DataBind();
            }
            catch (Exception ee) { }
        }


        protected void FirstChildRepeater_onItemDatabound(object sender, RepeaterItemEventArgs e)
        {
            AllClassicDBEntities entities = new AllClassicDBEntities();
            int answerID = int.Parse(DataBinder.Eval(e.Item.DataItem, "AnswerID").ToString());
            var SecondChildRepeater = (Repeater)e.Item.FindControl("SecondChildRepeater");
            SecondChildRepeater.DataSource = entities.AnswersTbls.Where(x => x.ParentAnswer == answerID).ToList();
            SecondChildRepeater.DataBind();

            //RepeaterItem item = e.Item;
            //if ((item.ItemType == ListItemType.Item) ||
            //    (item.ItemType == ListItemType.AlternatingItem))
            //{
            //    var detail = (Repeater)item.FindControl("SecondChildRepeater");
            //    int parentID = ((PerformanceCommentTbl)e.Item.DataItem).CommentID;
            //    detail.DataSource = CommentLogic.getCommentsByParentCommentID(parentID);
            //    detail.DataBind();

            //}
        }
                
        public void btnAddDetailDetailComment_Click(object sender, CommandEventArgs e)
        {

            RepeaterItem item = (sender as Button).NamingContainer as RepeaterItem;
            string message = (item.FindControl("txtCommentReplyParent") as TextBox).Text;

            AnswersTbl answer = new AnswersTbl();

            answer.Answer = message;
            answer.timestamp = DateTime.Now;
            answer.ParentAnswer = int.Parse(e.CommandArgument.ToString());
            answer.UserID = user.UserID;

            AllClassicDBEntities entities = new AllClassicDBEntities();
            entities.AnswersTbls.Add(answer);
            entities.SaveChanges();

            var SecondChildRepeater = (Repeater)item.FindControl("SecondChildRepeater");
            var mylist = entities.AnswersTbls.Where(x => x.ParentAnswer == answer.ParentAnswer).ToList();
            SecondChildRepeater.DataSource = entities.AnswersTbls.Where(x => x.ParentAnswer == answer.ParentAnswer).ToList();
            SecondChildRepeater.DataBind();


        }
        public void btnAddDetailComment_Click(object sender, CommandEventArgs e)
        {

            RepeaterItem item = (sender as Button).NamingContainer as RepeaterItem;
            string message = (item.FindControl("txtCommentReplyParent") as TextBox).Text;

            AnswersTbl answer = new AnswersTbl();

            answer.Answer = message;
            answer.timestamp = DateTime.Now;
            answer.ParentAnswer = int.Parse(e.CommandArgument.ToString());
            answer.UserID = user.UserID;

            AllClassicDBEntities entities = new AllClassicDBEntities();
            entities.AnswersTbls.Add(answer);
            entities.SaveChanges();

            var FirstChildRepeater = (Repeater)item.FindControl("FirstChildRepeater");
            var mylist = entities.AnswersTbls.Where(x => x.ParentAnswer == answer.ParentAnswer).ToList();
            FirstChildRepeater.DataSource = entities.AnswersTbls.Where(x => x.ParentAnswer == answer.ParentAnswer).ToList();
            FirstChildRepeater.DataBind();


        }

        public void btnAddAnswer_Click(object sender, CommandEventArgs e)
        {
            ListViewItem item = (sender as Button).NamingContainer as ListViewItem;
            string message = (item.FindControl("txtAddParentAnswer") as TextBox).Text;

            AnswersTbl answer = new AnswersTbl();
            answer.QuestionID = int.Parse(e.CommandArgument.ToString());
            answer.Answer = message;
            answer.timestamp = DateTime.Now;
            answer.UserID = 5;

            AllClassicDBEntities entities = new AllClassicDBEntities();
            entities.AnswersTbls.Add(answer);
            entities.SaveChanges();

            var detail = (Repeater)item.FindControl("ParentRepeater");
            var mylist = entities.AnswersTbls.Where(x => x.QuestionID == answer.QuestionID).ToList();
            detail.DataSource = entities.AnswersTbls.Where(x=>x.QuestionID==answer.QuestionID).ToList();
            detail.DataBind();


        }

        [System.Web.Services.WebMethod]
        [System.Web.Script.Services.ScriptMethod()]
        public static bool checkLoginStatus(int n)
        {

            return user != null;
        }

        public void showMsg(string msg)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + msg + "')", true);
        }


        public class questionModel
        {
            public int QuestionID;
            public string Question;
            public int UserID;
            public DateTime timestamp;
            public string posterEmailID;
        }
    }
}