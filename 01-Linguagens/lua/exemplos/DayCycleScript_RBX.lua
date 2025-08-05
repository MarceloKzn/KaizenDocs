-- Exemplo de: Ciclo de Dia e Noite dentro do Roblox Studio
local lighting = game:GetService("Lighting")
local dayLength = 600 -- Duração de um ciclo completo do dia e noite (em segundos)
local waitTime = 0.1 -- Intervalo entre cada atualização (em segundos)

-- Calcula o incremento de tempo por atualização
local increment = 24 / (dayLength / waitTime)
-- [ Basta Adicionar isso no (ServerScriptService) como Script]

-- Você também pode utilizar uma Table(é tipo uma Lista/Dicionário) para configurar as fases do Dia
-- DayStage = {
--      day = {
--          Brightness = 1.2
--            ...
--         }
--     night = {...}
--} também pode ser Utilizada como Array(ex: frutas = {"maçã", "banana", "laranja", "uva"})

while true do
    -- Incrementa o ClockTime(Tempo Atual) diretamente
    lighting.ClockTime = lighting.ClockTime + increment
    -- or lighting.ClockTime += increment

    -- Reseta para 0 se passar de 24
    if lighting.ClockTime >= 24 then
        lighting.ClockTime = lighting.ClockTime - 24
    end

    -- Ajusta o brilho com base no horário
    if lighting.ClockTime >= 6 and lighting.ClockTime < 18 and lighting.ClockTime > 15 then 
        lighting.Brightness = 1.5 -- Brilho do dia
        lighting.SunRays.Intensity = 0.05
    elseif lighting.ClockTime >= 8 and lighting.ClockTime <= 15  then
        lighting.Brightness = 1.9001
        lighting.SunRays.Intensity = 0.09
    else
        lighting.Brightness = 0.005 -- Brilho da noite
        lighting.SunRays.Intensity = 0.01
    end

    wait(waitTime)
end