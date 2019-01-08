## .NetCore-tryApi
1. Start the program in VS: browser shows 404 but it's ok
2. Start Postman
- POST=> "https://localhost:44327/v1/AddInventoryItems"
JSON=> 
{
	"id": "1",
	"ItemName": "Beer",
	"Price": 111
} 
+ GET=> "https://localhost:44327/v1/GetInventoryItems"
3. Result: return the JSON back
