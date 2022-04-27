using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using X22_Lab5_6.Models;

namespace X22_Lab5_6.Pages;

public class MapModel : PageModel
{
    public MapModel(ContactMapDBContext context,ILogger<MapModel> logger)
    {
        _logger = logger;
        _context = context;
    }

    private readonly ILogger<MapModel> _logger;
    private readonly ContactMapDBContext _context;
    public IList<Contact> ContactList { get; set; }

    public async Task OnGetAsync(){
        var contacts = from c in _context.Contacts select c;
        ContactList = await contacts.ToListAsync();        

         foreach(Contact c in ContactList){
             _logger.Log(LogLevel.Information, c.Name);
         }
    }
}

