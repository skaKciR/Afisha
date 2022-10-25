using System.Diagnostics.Tracing;
using Afisha.Domain.Repositories.Abstract;

namespace Afisha.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IEventRepository Events { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, IEventRepository eventRepository)
        {
            TextFields = textFieldsRepository;
            Events = eventRepository;
        }
    }
}
