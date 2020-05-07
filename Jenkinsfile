node {
  stage 'Checkout'
  git 'https://github.com/mammu26/Dotnet-core.git'
 
  stage 'Docker build'
  docker.build('app','./TrainingService/Dockerfile')
 
  stage 'Docker push'
  docker.withRegistry('https://358342348051.dkr.ecr.us-east-1.amazonaws.com', 'ecr:us-east-1:awsecr') {
    docker.image('app').push('latest')
  }
}
