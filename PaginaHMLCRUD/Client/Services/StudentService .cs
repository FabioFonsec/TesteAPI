using System.Net.Http.Json;

namespace PaginaHMLCRUD.Client.Services
{
    public class StudentService
    {
        private readonly HttpClient _httpClient;

        public StudentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Student>> GetStudentsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Student>>("api/students");
        }

        public async Task<Student> GetStudentAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Student>($"api/students/{id}");
        }

        public async Task<HttpResponseMessage> AddStudentAsync(Student student)
        {
            return await _httpClient.PostAsJsonAsync("api/students", student);
        }

        public async Task<HttpResponseMessage> UpdateStudentAsync(Student student)
        {
            return await _httpClient.PutAsJsonAsync($"api/students/{student.Id}", student);
        }

        public async Task<HttpResponseMessage> DeleteStudentAsync(int id)
        {
            return await _httpClient.DeleteAsync($"api/students/{id}");
        }
    }
}
