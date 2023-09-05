FROM nginx:mainline-alpine3.18-slim

COPY docker-entrypoint.sh /usr/local/bin/

RUN chmod +x /usr/local/bin/docker-entrypoint.sh

WORKDIR /usr/share/nginx/html/

COPY src/ .

ENTRYPOINT ["/usr/local/bin/docker-entrypoint.sh"]