pipeline {
    agent any

    stages {
        stage('Stage 1: Build') {
            steps {
                echo 'Task: Build the code by compiling and packaging the application. Tool: Maven.'
            }
        }

        stage('Stage 2: Unit and Integration Tests') {
            steps {
                echo 'Task: Run unit tests and integration tests to verify the application works correctly. Tool: JUnit and Maven Surefire/Failsafe.'
            }
        }

        stage('Stage 3: Code Analysis') {
            steps {
                echo 'Task: Analyse the source code to check code quality and ensure it meets industry standards. Tool: SonarQube.'
            }
        }

        stage('Stage 4: Security Scan') {
            steps {
                echo 'Task: Scan the source code and dependencies to identify security vulnerabilities. Tool: Snyk.'
            }
        }

        stage('Stage 5: Deploy to Staging') {
            steps {
                echo 'Task: Deploy the application to a staging server for testing in a production-like environment. Tool: AWS CodeDeploy on AWS EC2.'
            }
        }

        stage('Stage 6: Integration Tests on Staging') {
            steps {
                echo 'Task: Run integration tests on the staging environment to confirm the deployed application functions as expected. Tool: Postman Newman.'
            }
        }

        stage('Stage 7: Deploy to Production') {
            steps {
                echo 'Task: Deploy the validated application to the production server. Tool: AWS CodeDeploy on AWS EC2.'
            }
        }
    }
}
