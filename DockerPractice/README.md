# Docker File with .dockerignore

## Introduction

This repository is a simple practice project for learning and experimenting with Docker. It includes a basic setup for a web server (or application) to help understand Docker concepts like images, containers, Dockerfiles, and Docker Ignore.

## Getting Started

### Prerequisites

To run this project, you'll need:

- [Docker](https://www.docker.com/get-started) installed on your machine.

### Project Structure

```
├── Dockerfile             # Dockerfile for building the image
├── /DockerPractice        # Application code directory
└── README.md              # This README file
```

### Building the Docker Image

To build the Docker image, navigate to the project directory and run:

```sh
docker build -t my-docker-practice .
```

This command builds the Docker image using the `Dockerfile` in the current directory and tags it as `my-docker-practice`.

### Running the Container

To run the Docker container, use the following command:

```sh
docker run --name my-docker-practice -d -p 5841:8080 my-docker-practice
```

- `--name` provide the name of the container.
- `-d` runs the container in detached mode.
- `-p 5841:8080` maps port 5841 on your host to port 8080 in the container.

You can access the application at [http://localhost:5841](http://localhost:5841).

## Development

To make changes to the application, modify the files in the `DockerPractice/` directory. If you make changes to the Docker configuration (e.g., the `Dockerfile`), you may need to rebuild the image or restart the containers.

### Rebuilding the Image

After making changes to the Dockerfile or dependencies, rebuild the image:

```sh
docker build -t my-docker-practice .
```

### Restarting the Container

To restart the container with the latest image:

```sh
docker restart my-docker-practice
```

## Clean Up

To stop and remove the running container, use:

```sh
docker stop <container_id>
docker rm <container_id>
```

To remove the image:

```sh
docker rmi my-docker-practice
```

## Contributing

Feel free to fork this repository, submit pull requests, or open issues for improvements and suggestions.
