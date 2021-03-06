param([string] $version)

Set-Location "../"

# build docker images according to docker-compose
docker-compose build

# rename images with following tag
docker tag Neudesic-identityserver4-admin Neudesic/identityserver4-admin:$version
docker tag Neudesic-identityserver4-sts-identity Neudesic/identityserver4-sts-identity:$version
docker tag Neudesic-identityserver4-admin-api Neudesic/identityserver4-admin-api:$version

# push to docker hub
docker push Neudesic/identityserver4-admin:$version
docker push Neudesic/identityserver4-admin-api:$version
docker push Neudesic/identityserver4-sts-identity:$version
