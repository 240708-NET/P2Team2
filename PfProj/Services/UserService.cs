namespace PfProj.Services;

using AutoMapper;
using PfProj.Entities;
using PfProj.Helpers;
using PfProj.Models.DataModels;
using Services;

public interface ISharedService
{
    IEnumerable<DataModel> GetAll();
    DataModel GetById(int id);
    bool Create(CreateRequest model);
    bool Update(int id, UpdateRequest model);
    void Delete(int id);
}

public class ModelService : ISharedService
{
    private DataContext _context;
    private readonly IMapper _mapper;

    public ModelService(
        DataContext context,
        IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public IEnumerable<DataModel> GetAll()
    {
        return _context.DataModels;
    }

    public DataModel GetById(int id)
    {
        return getModel(id);
    }

    public bool Create(CreateRequest model)
    {
        // map model to new object
        var target = _mapper.Map<DataModel>(model);

        // manipulate data here

        // save to datacontext
        _context.DataModels.Add(target);
        _context.SaveChanges();
        return true;
    }
    public bool Update(int id, UpdateRequest model)
    {
        var targetId = getModel(id);
        //var target = _mapper.Map<DataModel>(model); 
        var target = _mapper.Map(model, targetId);
        
        // manipulate data here

        // update
        _context.DataModels.Update(targetId);
        _context.SaveChanges();
        return true;
    }

    public void Delete(int id)
    {
        var target = getModel(id);
        _context.DataModels.Remove(target);
        _context.SaveChanges();
    }

    // helper methods

    private DataModel getModel(int id)
    {
        var target = _context.DataModels.Find(id);
        if (target == null) throw new KeyNotFoundException("ID not found");
            return target;
    }

}