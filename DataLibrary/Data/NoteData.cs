using Dapper;
using DataLibrary.Db;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    public class NoteData : INoteData
    {
        private readonly IDataAccess _dataAccess;
        private readonly ConnectionStringData _connectionString;
        public NoteData(IDataAccess dataAccess, ConnectionStringData connectionString)
        {
            _dataAccess = dataAccess;
            _connectionString = connectionString;
        }

        public async Task<int> CreateNote(NoteModel note)
        {
            DynamicParameters p = new DynamicParameters();

            p.Add("Title", note.Title);
            p.Add("Description", note.Description);
            p.Add("Status", note.Status);
            p.Add("NoteDate", note.NoteDate);
            p.Add("Id", DbType.Int32, direction: ParameterDirection.Output);

            await _dataAccess.SaveData("dbo.spNotes_Insert", p, _connectionString.SqlConnectionName);

            return p.Get<int>("Id");
        }

        public Task<int> UpdateNote(int noteId, string noteDescription)
        {
            return _dataAccess.SaveData("dbo.spNotes_Update",
                                        new
                                        {
                                            Id = noteId,
                                            Description = noteDescription
                                        },
                                        _connectionString.SqlConnectionName);
        }

        public Task<int> DeleteNote(int noteId)
        {
            return _dataAccess.SaveData("dbo.spNotes_Delete",
                                        new
                                        {
                                            Id = noteId,

                                        },
                                        _connectionString.SqlConnectionName);
        }

        public Task<List<NoteModel>> All()
        {
            return  _dataAccess.LoadData<NoteModel, dynamic>("dbo.spNotes_All", new { }, _connectionString.SqlConnectionName);
        }

    
    }
}
