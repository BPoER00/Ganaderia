using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Ganaderia.Helpers
{
    public class ErrorHelpers
    {
             public class ErrorHelper 
     {
         public static ResponseObject Response(int StatusCode, string Message)
         {
             return new ResponseObject()
             {
                 Type = "C",
                 StatusCode = StatusCode,
                 Message = Message
             };
         }
 
         public static List<ModelErrors> GetModelStateErrors(ModelStateDictionary Model)
         {
             return Model.Select(x => new ModelErrors(){ Type = "M", Key = x.Key, Mesagges = 
             x.Value.Errors.Select(y => y.ErrorMessage).ToList()}).ToList();
         }
     }
 
     public class ResponseObject
     {
         public string Type { get; set; }
         public int StatusCode { get; set; }
         public string Message { get; set; }
     }
 
     public class ModelErrors
     {
         public string Type { get; set; }
         public string Key { get; set; }
         public List<string> Mesagges { get; set; }
     }
    }
}