Add-Migration Room -Context ApplicationDbContext
Update-Database Room -Context ApplicationDbContext
Add-Migration Hotel -Context Hotel_MVCContext
Update-Database Hotel -Context Hotel_MVCContext