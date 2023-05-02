FROM node:16.20.0-alpine3.16 as build
WORKDIR /AngularApp
COPY package*.json ./
RUN npm install
RUN npm i angular-responsive-carousel --force
COPY . /AngularApp
RUN npm run build
FROM nginx:1.21.0-alpine
COPY --from=build /app/dist/eshop-app /usr/share/nginx/html
EXPOSE 80
CMD ["nginx", "-g", "daemon off;"]
