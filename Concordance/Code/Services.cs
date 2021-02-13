using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Concordance
{
    class Services
    {
        private SqlConnection conn;
        public Services()
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            conn = new SqlConnection(connStr);
        }
        public void insertParsedDocToDB(Document document ,DataTable wordIndex)
        {
            
            try
            {
                conn.Open();
                SqlParameter[] Parameters = new SqlParameter[7];
                Parameters[0] = new SqlParameter();
                Parameters[0].ParameterName = "@name";
                Parameters[0].SqlDbType = SqlDbType.NVarChar;
                Parameters[0].Value = document.name;
                Parameters[1] = new SqlParameter();
                Parameters[1].ParameterName = "@author";
                Parameters[1].SqlDbType = SqlDbType.NVarChar;
                Parameters[1].Value = document.author;
                Parameters[2] = new SqlParameter();
                Parameters[2].ParameterName = "@fileName";
                Parameters[2].SqlDbType = SqlDbType.NVarChar;
                Parameters[2].Value = document.fileName;
                Parameters[3] = new SqlParameter();
                Parameters[3].ParameterName = "@link";
                Parameters[3].SqlDbType = SqlDbType.NVarChar;
                Parameters[3].Value = document.link;
                Parameters[4] = new SqlParameter();
                Parameters[4].ParameterName = "@datePublished";
                Parameters[4].SqlDbType = SqlDbType.Date;
                Parameters[4].Value = document.datePublished;
                Parameters[5] = new SqlParameter();
                Parameters[5].ParameterName = "@chapters";
                Parameters[5].SqlDbType = SqlDbType.Int;
                Parameters[5].Value = document.chapters;

                Parameters[6] = new SqlParameter();
                Parameters[6].ParameterName = "@wordIndexDT";
                Parameters[6].SqlDbType = SqlDbType.Structured;
                Parameters[6].Value = wordIndex;

                //Parameters[2].ParameterName = "@Return_Value";
                //Parameters[2].Direction = ParameterDirection.ReturnValue;

                SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "InsertParsedDocument", Parameters);

                conn.Close();
            }
            catch( Exception ex)
            {
                throw ex;
            }
            
        }
        public void test(DataTable wordIndex)
        {
            
            try
            {
                conn.Open();
                SqlParameter[] Parameters = new SqlParameter[1];

                Parameters[0] = new SqlParameter();
                Parameters[0].ParameterName = "@wordIndexDT";
                Parameters[0].SqlDbType = SqlDbType.Structured;
                Parameters[0].Value = wordIndex;
                
                SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, "TestSP", Parameters);
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        
        public DataTable getAutoCompleteWords(string text, int amount, int docId)
        {
            DataSet result;
            try
            {
                conn.Open();
                SqlParameter[] Parameters = new SqlParameter[3];

                Parameters[0] = new SqlParameter();
                Parameters[0].ParameterName = "@text";
                Parameters[0].SqlDbType = SqlDbType.NVarChar;
                Parameters[0].Value = text;
                Parameters[1] = new SqlParameter();
                Parameters[1].ParameterName = "@amount";
                Parameters[1].SqlDbType = SqlDbType.Int;
                Parameters[1].Value = amount;
                Parameters[2] = new SqlParameter();
                Parameters[2].ParameterName = "@docId";
                Parameters[2].SqlDbType = SqlDbType.Int;
                Parameters[2].Value = docId;

                result = SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, "GetAutoCompleteWords", Parameters);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result.Tables[0];
        }
        public int InsertGroupToDB(string name, DataTable groupWords)
        {
            int result;
            try
            {
                conn.Open();
                SqlParameter[] Parameters = new SqlParameter[2];

                Parameters[0] = new SqlParameter();
                Parameters[0].ParameterName = "@name";
                Parameters[0].SqlDbType = SqlDbType.NVarChar;
                Parameters[0].Value = name;
                Parameters[1] = new SqlParameter();
                Parameters[1].ParameterName = "@groupWords";
                Parameters[1].SqlDbType = SqlDbType.Structured;
                Parameters[1].Value = groupWords;

                result = SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "InsertGroup", Parameters);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public int InsertPhraseToDB(string phrase, DataTable phraseWords)//update this to save phrase string
        {
            int result;
            try
            {
                conn.Open();
                SqlParameter[] Parameters = new SqlParameter[2];

                Parameters[0] = new SqlParameter();
                Parameters[0].ParameterName = "@phraseWords";
                Parameters[0].SqlDbType = SqlDbType.Structured;
                Parameters[0].Value = phraseWords;
                Parameters[1] = new SqlParameter();
                Parameters[1].ParameterName = "@phrase";
                Parameters[1].SqlDbType = SqlDbType.NVarChar;
                Parameters[1].Value = phrase;

                result = SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "InsertPhrase", Parameters);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public int updateGroup(int groupId, string groupName ,DataTable groupWords)
        {
            int result;
            try
            {
                conn.Open();
                SqlParameter[] Parameters = new SqlParameter[3];

                Parameters[0] = new SqlParameter();
                Parameters[0].ParameterName = "@groupId";
                Parameters[0].SqlDbType = SqlDbType.Int;
                Parameters[0].Value = groupId;
                Parameters[1] = new SqlParameter();
                Parameters[1].ParameterName = "@name";
                Parameters[1].SqlDbType = SqlDbType.NVarChar;
                Parameters[1].Value = groupName;
                Parameters[2] = new SqlParameter();
                Parameters[2].ParameterName = "@groupWords";
                Parameters[2].SqlDbType = SqlDbType.Structured;
                Parameters[2].Value = groupWords;

                result = SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "updateGroup", Parameters);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public int updatePhrase(int phraseId,string phraseName, DataTable phraseWords)
        {
            int result;
            try
            {
                conn.Open();
                SqlParameter[] Parameters = new SqlParameter[3];
                
                Parameters[0] = new SqlParameter();
                Parameters[0].ParameterName = "@phraseId";
                Parameters[0].SqlDbType = SqlDbType.Int;
                Parameters[0].Value = phraseId;
                Parameters[1] = new SqlParameter();
                Parameters[1].ParameterName = "@name";
                Parameters[1].SqlDbType = SqlDbType.NVarChar;
                Parameters[1].Value = phraseName;
                Parameters[2] = new SqlParameter();
                Parameters[2].ParameterName = "@phraseWords";
                Parameters[2].SqlDbType = SqlDbType.Structured;
                Parameters[2].Value = phraseWords;

                result = SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "updatePhrase", Parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public DataTable getContextLinesAroundLine(int amountAboveBelow, int line, int docId)
        {
            DataSet result;
            try
            {
                conn.Open();
                SqlParameter[] Parameters = new SqlParameter[3];

                Parameters[0] = new SqlParameter();
                Parameters[0].ParameterName = "@amount";
                Parameters[0].SqlDbType = SqlDbType.Int;
                Parameters[0].Value = amountAboveBelow;
                Parameters[1] = new SqlParameter();
                Parameters[1].ParameterName = "@line";
                Parameters[1].SqlDbType = SqlDbType.Int;
                Parameters[1].Value = line;
                Parameters[2] = new SqlParameter();
                Parameters[2].ParameterName = "@docId";
                Parameters[2].SqlDbType = SqlDbType.Int;
                Parameters[2].Value = docId;

                result = SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, "GetContextAroundLine", Parameters);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result.Tables[0];
        }

        public DataTable getAllDocuments()
        {
            DataSet result;
            try
            {
                conn.Open();
                SqlParameter[] Parameters = new SqlParameter[0];
                
                result = SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, "GetAllDocuments", Parameters);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result.Tables[0];
        }
        public DataTable getTopFrequentWordsByDocId(int offset, int amount, int docId)//suppport docid=-1
        {
            DataSet result;
            try
            {
                conn.Open();
                SqlParameter[] Parameters = new SqlParameter[3];

                Parameters[0] = new SqlParameter();
                Parameters[0].ParameterName = "@offset";
                Parameters[0].SqlDbType = SqlDbType.Int;
                Parameters[0].Value = offset;
                Parameters[1] = new SqlParameter();
                Parameters[1].ParameterName = "@amount";
                Parameters[1].SqlDbType = SqlDbType.Int;
                Parameters[1].Value = amount;
                Parameters[2] = new SqlParameter();
                Parameters[2].ParameterName = "@docId";
                Parameters[2].SqlDbType = SqlDbType.Int;
                Parameters[2].Value = docId;

                result = SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, "getTopFrequentWordsByDocId", Parameters);
                //Id,value
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result.Tables[0];
        }

        public DataTable getWordIndexesByWordId(int wordId, int docId, int amount)
        {
            DataSet result;
            try
            {
                conn.Open();
                SqlParameter[] Parameters = new SqlParameter[3];

                Parameters[0] = new SqlParameter();
                Parameters[0].ParameterName = "@wordId";
                Parameters[0].SqlDbType = SqlDbType.Int;
                Parameters[0].Value = wordId;
                Parameters[1] = new SqlParameter();
                Parameters[1].ParameterName = "@docId";
                Parameters[1].SqlDbType = SqlDbType.Int;
                Parameters[1].Value = docId;
                Parameters[2] = new SqlParameter();
                Parameters[2].ParameterName = "@amount";
                Parameters[2].SqlDbType = SqlDbType.Int;
                Parameters[2].Value = amount;

                result = SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, "getWordIndexesByWordId", Parameters);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result.Tables[0];
        }

        public DataTable getWordIndexOfLineByDocId(int line, int docId)
        {
            DataSet result;
            try
            {
                conn.Open();
                SqlParameter[] Parameters = new SqlParameter[2];

                Parameters[0] = new SqlParameter();
                Parameters[0].ParameterName = "@line";
                Parameters[0].SqlDbType = SqlDbType.Int;
                Parameters[0].Value = line;
                Parameters[1] = new SqlParameter();
                Parameters[1].ParameterName = "@docId";
                Parameters[1].SqlDbType = SqlDbType.Int;
                Parameters[1].Value = docId;
                
                result = SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, "getWordIndexOfLineByDocId", Parameters);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result.Tables[0];
        }
        public DataTable getWordIndexOfSentenceByDocId(int sentence, int docId)
        {
            DataSet result;
            try
            {
                conn.Open();
                SqlParameter[] Parameters = new SqlParameter[2];

                Parameters[0] = new SqlParameter();
                Parameters[0].ParameterName = "@sentence";
                Parameters[0].SqlDbType = SqlDbType.Int;
                Parameters[0].Value = sentence;
                Parameters[1] = new SqlParameter();
                Parameters[1].ParameterName = "@docId";
                Parameters[1].SqlDbType = SqlDbType.Int;
                Parameters[1].Value = docId;
                
                result = SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, "getWordIndexOfSentenceByDocId", Parameters);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result.Tables[0];
        }

        public DataTable getGroupWordsById(int id)
        {
            DataSet result;
            try
            {
                conn.Open();
                SqlParameter[] Parameters = new SqlParameter[1];

                Parameters[0] = new SqlParameter();
                Parameters[0].ParameterName = "@Id";
                Parameters[0].SqlDbType = SqlDbType.Int;
                Parameters[0].Value = id;
                
                result = SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, "getGroupWordsById", Parameters);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result.Tables[0];
        }

        public DataTable getPhraseWordsById(int id)
        {
            DataSet result;
            try
            {
                conn.Open();
                SqlParameter[] Parameters = new SqlParameter[1];

                Parameters[0] = new SqlParameter();
                Parameters[0].ParameterName = "@Id";
                Parameters[0].SqlDbType = SqlDbType.Int;
                Parameters[0].Value = id;

                result = SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, "getPhraseWordsById", Parameters);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result.Tables[0];
        }
        public DataTable getAllGroupNames()
        {
            DataSet result;
            try
            {
                conn.Open();
                SqlParameter[] Parameters = new SqlParameter[0];

                result = SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, "getAllGroupNames", Parameters);
                //Id, name
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result.Tables[0];
            //Id, name
        }
        public DataTable getAllPhraseNames()
        {
            DataSet result;
            try
            {
                conn.Open();
                SqlParameter[] Parameters = new SqlParameter[0];

                result = SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, "getAllPhraseNames", Parameters);
                //phrase.Id, name
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result.Tables[0];
            //Id, name
        }
        public DataTable getWordIndexesByPhraseId(int id)
        {
            DataSet result;
            try
            {
                conn.Open();
                SqlParameter[] Parameters = new SqlParameter[1];

                Parameters[0] = new SqlParameter();
                Parameters[0].ParameterName = "@phraseId";
                Parameters[0].SqlDbType = SqlDbType.Int;
                Parameters[0].Value = id;

                result = SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, "getWordIndexesByPhraseId", Parameters);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result.Tables[0];
            //docId, chapter, sentence, firstWordLine, firstWordColumn, lastWordLine, lastWordColumn, lastWordLength
        }

        public DataTable getWordIndexesByGroupId(int id)
        {
            DataSet result;
            try
            {
                conn.Open();
                SqlParameter[] Parameters = new SqlParameter[1];

                Parameters[0] = new SqlParameter();
                Parameters[0].ParameterName = "@groupId";
                Parameters[0].SqlDbType = SqlDbType.Int;
                Parameters[0].Value = id;

                result = SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, "getWordIndexesByGroupId", Parameters);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result.Tables[0];
            //docId, wordIndex.wordId, [value], chapter, line, [column], sentence, wordOrdinal, tokenOrdinal
        }

        public DataTable getStatistics()
        {
            DataSet result;
            try
            {
                conn.Open();
                SqlParameter[] Parameters = new SqlParameter[0];

                result = SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, "getStatistics", Parameters);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result.Tables[0];
        }

        public DataTable getInflectionsByWordId(int wordId)
        {
            DataSet result;
            try
            {
                conn.Open();
                SqlParameter[] Parameters = new SqlParameter[1];

                Parameters[0] = new SqlParameter();
                Parameters[0].ParameterName = "@wordId";
                Parameters[0].SqlDbType = SqlDbType.Int;
                Parameters[0].Value = wordId;

                result = SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, "getInflectionsByWordId", Parameters);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result.Tables[0];
        }
        public DataTable getInflectedWordIndexesBywordId(int wordId)
        {
            DataSet result;
            try
            {
                conn.Open();
                SqlParameter[] Parameters = new SqlParameter[1];

                Parameters[0] = new SqlParameter();
                Parameters[0].ParameterName = "@wordId";
                Parameters[0].SqlDbType = SqlDbType.Int;
                Parameters[0].Value = wordId;

                result = SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, "getInflectedWordIndexesBywordId", Parameters);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result.Tables[0];
        }
        public DataTable getDocsByFieldAndWords(string fieldsText, DataTable wordsToContain)//update this to save phrase string
        {
            DataSet result;
            try
            {
                conn.Open();
                SqlParameter[] Parameters = new SqlParameter[2];

                Parameters[0] = new SqlParameter();
                Parameters[0].ParameterName = "@wordsToContain";
                Parameters[0].SqlDbType = SqlDbType.Structured;
                Parameters[0].Value = wordsToContain;
                Parameters[1] = new SqlParameter();
                Parameters[1].ParameterName = "@fieldsText";
                Parameters[1].SqlDbType = SqlDbType.NVarChar;
                Parameters[1].Value = fieldsText;

                result = SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, "getDocsByFieldAndWords", Parameters);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result.Tables[0];
        }

        public string getGroupName(int groupId)
        {
            DataSet result;
            try
            {
                conn.Open();
                SqlParameter[] Parameters = new SqlParameter[1];

                Parameters[0] = new SqlParameter();
                Parameters[0].ParameterName = "@groupId";
                Parameters[0].SqlDbType = SqlDbType.Int;
                Parameters[0].Value = groupId;

                result = SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, "getGroupName", Parameters);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result.Tables[0].Rows[0][0].ToString();
        }
    }
}
