using DataLibrary.Models;

namespace DataLibrary.Data
{
    public interface INoteData
    {
        Task<int> CreateNote(NoteModel note);
        Task<int> DeleteNote(int noteId);
        Task<NoteModel> GetNoteById(int noteId);
        Task<int> UpdateNoteStatus(int noteId, string noteStatus);
    }
}