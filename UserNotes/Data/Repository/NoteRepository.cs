using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using UserNotes.Data.Base;
using UserNotes.Data.Repository.IRepository;
using UserNotes.Models;

namespace UserNotes.Data.Repository
{
    public class NoteRepository : BaseRepository, INoteRepository
    {
        public NoteRepository(IHelperConnectionString helper) : base(helper)
        { }

        public bool AddNote(Note note)
        {
            throw new NotImplementedException();
        }

        public bool DeleteNote(int noteId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Note> GetAllNote()
        {
            throw new NotImplementedException();
        }

        public Note GetNoteById(int noteId)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@NoteId", noteId);
                return SqlMapper.Query<Note>(con, "GetNoteById", parameters).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool UpdateNote(Note note)
        {
            throw new NotImplementedException();
        }
    }
}
