using System;

namespace Bloc_5___Pràctica_Troncal_A3_dbContext_v2
{
	public class ValidationResult<T>
	{
        public T ValidatedResult { get; set; }

        public bool ValidationSuccesful { get; set; }

        /// No entiendo que crees una lista de mensajes??
        /// Entendería que esta lista de mensajes fuera un Dictionary<int, string> 
        /// y que cuando quisiera poner el error Not Found llamara al int 404, por ejemplo, 
        /// y de esta manera tener una librería de errores.
        

	}
}
