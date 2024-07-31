#version 330 core
out vec4 FragColor;

in vec3 Normal;
in vec3 FragPos;
in vec2 TexCoords;

uniform sampler2D texture1;
uniform sampler2D texture2;

void main()
{
    vec3 color = mix(texture(texture1, TexCoords).rgb, texture(texture2, TexCoords).rgb, 0.5);
    FragColor = vec4(color, 1.0);
}
