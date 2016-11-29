using JCC.Domain.Entities;
using JCC.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCC.Service
{
    class FilmService : Service<Film>, IFilmService
    {

        public FilmService()

        {



        }


    }
    public interface IFilmService : IService<Film>
    {

    }
}
