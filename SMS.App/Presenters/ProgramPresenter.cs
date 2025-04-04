using Microsoft.EntityFrameworkCore;
using SMS.App.Views.iViews;
using SMS.Domain;
using SMS.Infrastructure.Data;
using System.Drawing.Text;

namespace SMS.App.Presenters
{
    public class ProgramPresenter
    {
        private IProgramView _programView;
        private AppDbContext _dbContext;
        private IEnumerable<Programs> _programList;
        private BindingSource _bindingSource;

        public ProgramPresenter(IProgramView programView)
        {
            _programView = programView;
            _dbContext = new AppDbContext();
            _bindingSource = new BindingSource();

            _programView.CreateEvent += CreateEvent;
            _programView.ReadEvent += ReadEvent;
            _programView.UpdateEvent += UpdateEvent;
            _programView.DeleteEvent += DeleteEvent;
            
            _programView.GetProgramList(_bindingSource);
        }
        private void LoadProgramList()
        {
            _programList = _dbContext.Programs.ToList();
            _bindingSource.DataSource = _programList;
        }

        private void DeleteEvent(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void CreateEvent(object sender, EventArgs e)
        {
            var program = new Programs
            {
                ProgramName = _programView.ProgramName,
                Description = _programView.Description
            };
            _dbContext.Programs.Add(program);
            _dbContext.SaveChanges();

            LoadProgramList();
        }
        private void UpdateEvent(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void ReadEvent(object sender, EventArgs e)
        {
            LoadProgramList();
        }
    }
}
