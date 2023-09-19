# MockClothesAPI

### Description
The MockClothes API is a project that provides an interface to access a collection of clothes. It allows users to fetch a list of users, products, different categories of clothes, and product reviews. This readme file serves as a guide to understand the functionalities and usage of the API.

## Getting Started
To get started with the MockClothes API, follow the steps below:

Clone the project repository from GitHub:

```
git clone https://github.com/modestsp/MockClothesCommerceAPI.git
```
Navigate to the project directory:

```
cd MockClothesCommercerAPI
```
Restore the project dependencies using the .NET CLI:
```
dotnet restore
```
#### Start the API server using the .NET CLI:
```
dotnet run
```
The API should now be running locally on http://localhost:5000 or https://localhost:5001 if using HTTPS. You can make requests to this address using tools like Postman or cURL.

### Docker
Pull the docker image from DockerHub:
```
docker pull modestsp/mock_clothes_api:v1
```
Run the image:
```
docker run -p 8080:80 modestsp/mock_clothes_api:v1
```
In case you want to use Swagger:
```
docker run -p 8080:80 -e ASPNETCORE_ENVIROnMENT='Development' modestsp/mock_clothes_api:v1
```
The API should new be running locally on http://localhost:8080. You can make request using tools like Postman or cURL.

### Features
The MockClothes API offers the following features:

### User Management:

- Fetch a list of users
```
curl -X 'GET' \
  'http://localhost:8080/Users' \
  -H 'accept: */*'
```
- Retrieve user details by ID
```
curl -X 'GET' \
  'http://localhost:8080/Users/1' \
  -H 'accept: */*'
```
- Add a new user
```
  curl -X 'POST' \
  'http://localhost:8080/Users' \
  -H 'accept: */*' \
  -H 'Content-Type: application/json' \
  -d '{
  "name": "usertest",
  "username": "usertest",
  "email": "usertest@mail.com",
  "password": "UserTest-123"
}'
```
- Update user information
```
curl -X 'PUT' \
  'http://localhost:8080/Users/1' \
  -H 'accept: */*' \
  -H 'Content-Type: application/json' \
  -d '{
  "name": "string",
  "email": "string",
  "password": "string"
}'
```
- Delete a user
```
curl -X 'DELETE' \
  'http://localhost:8080/Users/12' \
  -H 'accept: */*'
```
- Get favorites products from user
```
curl -X 'GET' \
  'http://localhost:8080/Users/12/favorites' \
  -H 'accept: */*'
```
- Delete favorites
```
curl -X 'DELETE' \
  'http://localhost:8080/Users/1/favorites/1' \
  -H 'accept: */*' \
  -H 'Content-Type: application/json' \
  -d '{
  "userId": 1,
  "productId": 1
}'
```
### Product Management:

- Fetch a list of products
- Retrieve product details by ID
- Add a new product
- Update product information
- Delete a product
- Add to favorites
- Add a review

### Category Management:

- Fetch a list of categories
- Retrieve category details by ID
- Filter products by category
- Delete a category

### Product Review Management:

- Fetch product reviews
- Retrieve product review details by ID
- Update product review information
- Delete a product review

## API Documentation
For detailed information about the API endpoints and their usage, please refer to the API Docs page https://mockclothesdocs.vercel.app/.

## Technologies Used

This app was built using the following technologies:

- ASP.NETCORE 6.0
- Entiy Framework In Memory
- AutoMapper
- Swagger
- Docker

### License
The MockClothes API project is licensed under the MIT License.

## Contact
If you have any questions, suggestions, or feedback regarding the Clothes API, please contact the project maintainer at csperichon@gmail.com.

Thank you for using the MockClothes API!
