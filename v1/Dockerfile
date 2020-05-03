FROM openjdk:alpine
LABEL maintainer="info@satellytes.com"

# Install chattr
RUN apk update && apk add e2fsprogs-extra

EXPOSE 8080

# wrapper executes the java command
COPY wrapper.sh /wrapper.sh

COPY build/libs/satellytes-main-*.jar /app.jar

# run app under webuser with low rights
RUN addgroup webuser \
    && adduser -D -G webuser webuser \
    && chown webuser:webuser wrapper.sh \
	&& chmod 500 /wrapper.sh \
	&& chown webuser:webuser /app.jar \
    && chmod 500 /app.jar

# This will prevent any user, including root, from modifying the jar.
# Unfortunately this does not work on alpine
#RUN chattr +i /app.jar

ENTRYPOINT ["sh","/wrapper.sh"]

