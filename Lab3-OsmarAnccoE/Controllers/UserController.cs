using Microsoft.AspNetCore.Mvc;
using Lab3_OsmarAnccoE.Models;
using Lab3_OsmarAnccoE.Repositories;
using Lab3_OsmarAnccoE.Dtos;

namespace Lab3_OsmarAnccoE.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var users = await _userRepository.GetAllAsync();
            return Ok(users);
        }

        // GET: api/Users/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(Guid id)
        {
            var user = await _userRepository.GetByIdAsync(id);

            if (user == null)
            {
                return NotFound($"Usuario con id {id} no encontrado.");
            }

            return Ok(user);
        }

        // POST: api/Users
        [HttpPost]
        public async Task<ActionResult<User>> PostUser([FromBody] UserCreateDto userDto) // <-- CAMBIO AQUÍ
        {
            // Mapear el DTO
            var newUser = new User
            {
                Name = userDto.Name,
                Phonenumber = userDto.Phonenumber,
                Dni = userDto.Dni,
                Email = userDto.Email,
                Password = userDto.Password,
                RoleId = userDto.RoleId,
                Status = userDto.Status,

                // Propiedades que genera el servidor
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
            
            await _userRepository.AddAsync(newUser);

            return CreatedAtAction(nameof(GetUser), new { id = newUser.Id }, newUser);
        }

        // PUT: api/Users/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(Guid id, [FromBody] UserUpdateDto userDto)
        {
            var userToUpdate = await _userRepository.GetByIdAsync(id);

            if (userToUpdate == null)
            {
                return NotFound($"Usuario con id {id} no encontrado para actualizar.");
            }
            
            userToUpdate.Name = userDto.Name;
            userToUpdate.Phonenumber = userDto.Phonenumber;
            userToUpdate.Dni = userDto.Dni;
            userToUpdate.Email = userDto.Email;
            userToUpdate.RoleId = userDto.RoleId;
            userToUpdate.Status = userDto.Status;
            userToUpdate.UpdatedAt = DateTime.UtcNow;
            
            await _userRepository.UpdateAsync(userToUpdate);

            return NoContent(); 
        }

        // DELETE: api/Users/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            var userToDelete = await _userRepository.GetByIdAsync(id);
            if (userToDelete == null)
            {
                return NotFound($"Usuario con id {id} no encontrado para eliminar.");
            }

            await _userRepository.DeleteAsync(id);

            return NoContent();
        }
        
        // GET: api/Users/byemail/test@example.com
        [HttpGet("byemail/{email}")]
        public async Task<ActionResult<User>> GetUserByEmail(string email)
        {
            var user = await _userRepository.GetByEmailAsync(email);

            if (user == null)
            {
                return NotFound($"No se encontró un usuario con el email: {email}");
            }

            return Ok(user);
        }
    }
}