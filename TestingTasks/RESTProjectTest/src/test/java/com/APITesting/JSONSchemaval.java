package com.APITesting;

import static io.restassured.RestAssured.*;   // Make a static to RestAssured Package
import static io.restassured.module.jsv.JsonSchemaValidator.matchesJsonSchemaInClasspath;

import org.testng.annotations.Test;

public class JSONSchemaval {

		@Test
	
	public void testGet1() {
		
		baseURI = "http://localhost:8888/";
		
		given().get("/user").
		then().
		assertThat().body(matchesJsonSchemaInClasspath("schema.json")).statusCode(200);
	}
}