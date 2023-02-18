import './style.css'

import {WeatherForecastService, OpenAPI } from "../../api/index.js";

export async function run() {
  OpenAPI.BASE = "http://localhost:5230";
    const forecasts = await WeatherForecastService.getWeatherForecast();
    console.log(forecasts);
}

run();