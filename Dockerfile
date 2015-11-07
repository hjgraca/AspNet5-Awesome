FROM microsoft/aspnet:1.0.0-beta8

COPY ./src/AspNet5-Awesome/project.json /app/
WORKDIR /app
RUN ["dnu", "restore"]
COPY ./src/AspNet5-Awesome /app


EXPOSE 5000
ENTRYPOINT ["dnx", "-p", "project.json", "web"]
