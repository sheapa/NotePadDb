using DataLibrary.Models;

namespace DataLibrary.Data
{
    public interface INoteData
    {
        Task<int> CreateNote(NoteModel note);
        Task<int> DeleteNote(int noteId);
        Task <List<NoteModel>> All();
        Task<int> UpdateNote(int noteId, string noteDescription);
    }
}