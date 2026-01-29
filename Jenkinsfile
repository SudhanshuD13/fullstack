options {
    skipDefaultCheckout(true)
}

stages {

    stage('Prepare Workspace') {
        steps {
            cleanWs()          // Sirf ek baar clean
            checkout scm       // Fresh code fetch
        }
    }

    stage('Gitleaks Scan') {
        steps {
            echo 'Downloading and Running Gitleaks...'
            sh """
            curl -L https://github.com/gitleaks/gitleaks/releases/download/v8.18.2/gitleaks_8.18.2_linux_x64.tar.gz -o gitleaks.tar.gz
            
            tar -xzf gitleaks.tar.gz
            chmod +x gitleaks
            
            ./gitleaks detect --source=. --no-git --verbose
            
            rm -f gitleaks gitleaks.tar.gz
            """
        }
    }

    stage('SonarQube Analysis') {
        steps {
            echo 'SonarQube stage coming soon...'
        }
    }
}

post {
    always {
        echo "Pipeline finished."
    }
}
