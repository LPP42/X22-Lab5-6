using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using X22_Lab5_6.Models;

namespace X22_Lab5_6.Pages;

public class ContactModel : PageModel
{

    [BindProperty]
    public Contact Contact { get; set; }
    private readonly ContactMapDBContext _context;
    private readonly ILogger<ContactModel> _logger;

    public ContactModel(ContactMapDBContext context, ILogger<ContactModel> logger)
    {
        _context = context;
        _logger = logger;
        
    }
    
    public void OnGet()
    {
    }


    
    public async Task<IActionResult> OnPostAsync()
        {              
                        _context.Contacts.Add(Contact);
                        await _context.SaveChangesAsync();
                        return RedirectToPage("./Index");                                                          
        }
}

