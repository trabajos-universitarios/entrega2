# syntax=docker/dockerfile:1.4

FROM python:3 AS builder
EXPOSE 8000
# Instalar dependencias
RUN apt-get update && apt-get install -y unixodbc-dev

RUN apt-get update && apt-get install -y unixodbc 

RUN apt-get update && apt-get install -y gnupg2
RUN curl https://packages.microsoft.com/keys/microsoft.asc | apt-key add -
RUN curl https://packages.microsoft.com/config/debian/10/prod.list > /etc/apt/sources.list.d/mssql-release.list
RUN apt-get update && ACCEPT_EULA=Y apt-get install -y msodbcsql17

WORKDIR /usr/src/app

COPY requirements.txt ./
RUN pip install --upgrade pip
RUN pip install --no-cache-dir -r requirements.txt

COPY . .
CMD ["python3", "manage.py", "runserver", "0.0.0.0:8010"]
