using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Notes.Application.Interfaces;

namespace Notes.Application.Notes.Queries.GetNoteList
{
    public class GetNoteListQuery : IRequest<NoteListVm>
    {
       public Guid UserId { get; set; }

    }
}
