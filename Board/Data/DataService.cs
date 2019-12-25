using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Board.Data
{
    public class DataService
    {
        #region get/select query
        public static List<CardProp> GetCardByCardID(int card_ID)
        {
            using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                connection.Open();
                return connection.Query<CardProp>($"execute GetCardByCardID @Card_ID = {card_ID}").ToList();
            }
        }

        public static List<CardProp> GetCardByListID(int list_ID)
        {
            using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                connection.Open();
                return connection.Query<CardProp>($"execute GetCardByListID @List_ID = {list_ID}").ToList();
            }
        }

        public static List<DueDateProp> GetDueDateByCardID(int card_ID)
        {
            using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                connection.Open();
                return connection.Query<DueDateProp>($"execute GetDueDateByCardID @Card_ID = {card_ID}").ToList();
            }
        }

        public static List<CheckListProp> GetCheckListByCardID(int card_ID)
        {
            using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                connection.Open();
                return connection.Query<CheckListProp>($"execute GetCheckListByCardID @Card_ID = {card_ID}").ToList();
            }
        }

        public static List<ItemProp> GetItemByCheckListID(int checkList_ID)
        {
            using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                connection.Open();
                return connection.Query<ItemProp>($"execute GetItemByCheckListID @CheckList_ID = {checkList_ID}").ToList();
            }
        }

        public static  List<ListProp> GetListByBoardID(int board_ID)
        {
            using(IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                connection.Open();
                return connection.Query<ListProp>($"execute GetListByBoardID @Board_ID = {board_ID}").ToList();
            }
        }

        public static List<ListProp> GetListByListID(int list_ID)
        {
            using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                connection.Open();
                return connection.Query<ListProp>($"execute GetListByListID @List_ID = {list_ID}").ToList();
            }
        }

        public static List<BoardProp> GetBoardByBoardID(int board_ID)
        {
            using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                connection.Open();
                return connection.Query<BoardProp>($"execute GetBoardByBoardID @Board_ID = {board_ID}").ToList();
            }
        }

        public static List<BoardProp> GetAllBoard()
        {
            using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                connection.Open();
                return connection.Query<BoardProp>("select * from Board order by Board_Position").ToList();
            }
        }
        #endregion

        #region insert query
        public static void InsertBoard(BoardProp boardProp)
        {
            using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                connection.Open();
                connection.Execute("InsertBoard", new { Board_Name = boardProp.Board_Name, Board_Position = boardProp.Board_Position}, commandType: CommandType.StoredProcedure);
            }
        }

        public static void InsertList(ListProp listProp)
        {
            using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                connection.Open();
                DynamicParameters dp = new DynamicParameters();
                dp.AddDynamicParams(new 
                { 
                    Board_ID = listProp.Board_ID, 
                    List_Name = listProp.List_Name, 
                    List_Observing = listProp.List_Observing, 
                    List_Position = listProp.List_Position 
                });
                connection.Execute("InsertList", dp, commandType: CommandType.StoredProcedure);
            }
        }

        public static void InsertCard(CardProp cardProp)
        {
            using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                connection.Open();
                DynamicParameters dp = new DynamicParameters();
                dp.AddDynamicParams(new
                {
                    List_ID = cardProp.List_ID,
                    Card_Name = cardProp.Card_Name,
                    Card_Observing = cardProp.Card_Observing,
                    Card_Position = cardProp.Card_Position,
                    Card_Description =  cardProp.Card_Description
                });
                connection.Execute("InsertCard", dp, commandType: CommandType.StoredProcedure);
            }
        }

        public static void InsertDueDate(DueDateProp duedateProp)
        {
            using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                connection.Open();
                DynamicParameters dp = new DynamicParameters();
                dp.AddDynamicParams(new 
                { 
                    Card_ID = duedateProp.Card_ID, 
                    DueDate_DateTime = duedateProp.DueDate_DateTime, 
                    DueDate_Reminder = duedateProp.DueDate_Reminder, 
                    DueDate_Checked = duedateProp.DueDate_Checked 
                });
                connection.Execute("InsertDueDate", dp, commandType: CommandType.StoredProcedure);

            }
        }

        public static void InsertCheckList(CheckListProp checkListProp)
        {
            using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                connection.Open();
                DynamicParameters dp = new DynamicParameters();
                dp.AddDynamicParams(new
                {
                    Card_ID =  checkListProp.Card_ID,
                    CheckList_Name =  checkListProp.CheckList_Name,
                    CheckList_Position =  checkListProp.CheckList_Position
                });
                connection.Execute("InsertCheckList", dp, commandType: CommandType.StoredProcedure);
            }
        }

        public static void InsertItem(ItemProp itemProp)
        {
            using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                connection.Open();
                DynamicParameters dp = new DynamicParameters();
                dp.AddDynamicParams(new
                {
                    CheckList_ID = itemProp.CheckList_ID,
                    Item_Description = itemProp.Item_Description,
                    Item_Checked = itemProp.Item_Checked,
                    Item_Position = itemProp.Item_Position
            });
                connection.Execute("InsertItem", dp, commandType: CommandType.StoredProcedure);
            }
        }
        #endregion

        #region delete query
        public static void DeleteCard(CardProp cardProp)
        {
            using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                connection.Open();
                connection.Execute("DeleteCard", new { Card_ID = cardProp.Card_ID }, commandType: CommandType.StoredProcedure);
            }
        }

        public static void DeleteList(ListProp listProp)
        {
            using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                connection.Open();
                connection.Execute("DeleteList", new { List_ID = listProp.List_ID}, commandType: CommandType.StoredProcedure);
            }
        }

        public static void DeleteBoard(BoardProp boardProp)
        {
            using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                connection.Open();
                connection.Execute("DeleteBoard", new { Board_ID = boardProp.Board_ID}, commandType: CommandType.StoredProcedure);
            }
        }

        public static void DeleteDueDate(DueDateProp dueDateProp)
        {
            using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                connection.Open();
                connection.Execute("DeleteDueDate", new { DueDate_ID = dueDateProp.DueDate_ID}, commandType: CommandType.StoredProcedure);
            }
        }

        public static void DeleteCheckList(CheckListProp checkListProp)
        {
            using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                connection.Open();
                connection.Execute("DeleteCheckList", new { CheckList_ID = checkListProp.CheckList_ID}, commandType: CommandType.StoredProcedure);
            }
        }

        public static void DeleteItem(ItemProp itemProp)
        {
            using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                connection.Open();
                connection.Execute("DeleteItem",  new { Item_ID = itemProp.Item_ID}, commandType: CommandType.StoredProcedure);
            }
        }
        #endregion

        #region Update query
        public static void UpdateCard(CardProp cardProp)
        {
            using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                connection.Open();
                DynamicParameters dp = new DynamicParameters();
                dp.AddDynamicParams(new
                {
                    Card_ID = cardProp.Card_ID,
                    List_ID = cardProp.List_ID,
                    Card_Name = cardProp.Card_Name,
                    Card_Observing = cardProp.Card_Observing,
                    Card_Position = cardProp.Card_Position,
                    Card_Description = cardProp.Card_Description
                });
                connection.Execute("UpdateCard", dp, commandType: CommandType.StoredProcedure);
            }
        }

        public static void UpdateList(ListProp listProp)
        {
            using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                connection.Open();
                DynamicParameters dp = new DynamicParameters();
                dp.AddDynamicParams(new
                {
                    List_ID = listProp.List_ID,
                    Board_ID = listProp.Board_ID,
                    List_Name = listProp.List_Name,
                    List_Observing = listProp.List_Observing,
                    List_Position = listProp.List_Position
                });
                connection.Execute("UpdateList", dp, commandType: CommandType.StoredProcedure);
            }
        }

        public static void UpdateBoard(BoardProp boardProp)
        {
            using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                connection.Open();
                DynamicParameters dp = new DynamicParameters();
                dp.AddDynamicParams(new
                {
                    Board_ID = boardProp.Board_ID,
                    Board_Name = boardProp.Board_Name,
                    Board_Position = boardProp.Board_Position
                });
                connection.Execute("UpdateBoard", dp, commandType: CommandType.StoredProcedure);
            }
        }

        public static void UpdateDueDate(DueDateProp duedateProp)
        {
            using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                connection.Open();
                DynamicParameters dp = new DynamicParameters();
                dp.AddDynamicParams(new
                {
                    DueDate_ID = duedateProp.DueDate_ID,
                    Card_ID = duedateProp.Card_ID,
                    DueDate_DateTime = duedateProp.DueDate_DateTime,
                    DueDate_Reminder = duedateProp.DueDate_Reminder,
                    DueDate_Checked = duedateProp.DueDate_Checked
                });
                connection.Execute("UpdateDueDate", dp, commandType: CommandType.StoredProcedure);
            }
        }

        public static void UpdateCheckList(CheckListProp checklistProp)
        {
            using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                connection.Open();
                DynamicParameters dp = new DynamicParameters();
                dp.AddDynamicParams(new
                {
                    CheckList_ID = checklistProp.CheckList_ID,
                    Card_ID = checklistProp.Card_ID,
                    CheckList_Name = checklistProp.CheckList_Name,
                    CheckList_Position = checklistProp.CheckList_Position
                });
                connection.Execute("UpdateCheckList", dp, commandType: CommandType.StoredProcedure);
            }
        }

        public static void UpdateItem(ItemProp itemProp)
        {
            using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                connection.Open();
                DynamicParameters dp = new DynamicParameters();
                dp.AddDynamicParams(new
                {
                    Item_ID = itemProp.Item_ID,
                    CheckList_ID = itemProp.CheckList_ID,
                    Item_Description = itemProp.Item_Description,
                    Item_Checked = itemProp.Item_Checked,
                    Item_Position = itemProp.Item_Position
                });
                connection.Execute("UpdateItem", dp, commandType: CommandType.StoredProcedure);
            }
        }
        #endregion
    }

}
