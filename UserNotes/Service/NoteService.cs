using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserNotes.Data.Repository.IRepository;
using UserNotes.Models;
using UserNotes.Service.IService;

namespace UserNotes.Service
{
    public class NoteService : INoteService
    {
        private INoteRepository _repository;
        public NoteService(INoteRepository repository)
        {
            _repository = repository;
        }
        public Note GetNoteById(int id)
        {
            return _repository.GetNoteById(id);
        }
    }
}
